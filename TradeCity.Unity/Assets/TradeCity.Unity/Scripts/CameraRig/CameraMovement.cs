using System;
using System.Diagnostics;
using AutSoft.UnitySupplements.EventBus;
using AutSoft.UnitySupplements.Vitamins;
using Injecter;
using TradeCity.Engine.Core;
using TradeCity.Unity.Scripts.GUI.Navigation;
using UnityEngine;
using UnityEngine.UIElements;

namespace TradeCity.Unity.Scripts.CameraRig
{
    internal enum CameraFocus
    {
        Map,
        City
    }

    public class CameraMovement : MonoBehaviour
    {
        [Inject] private IEventBus _eventBus = default!;

        [SerializeField] private GameObject _cameraRigGameObject = default!;
        [SerializeField] private Camera _camera = default!;
        [SerializeField] private Terrain _terrain = default!;

        [Header("BoundingBoxes")]
        [SerializeField] private Bounds _mapBounds = default!;
        [SerializeField] private Bounds _cityBounds = default!;

        [Header("Movement")]
        [SerializeField] private float _maxMovementSpeed = default!;
        [SerializeField] private float _movementAcceleration = default!;
        [SerializeField] private float _turnRate = default!;
        [SerializeField] private float _movementDeAcceleration = default;
        [SerializeField] private float _boostModifier = default!;

        [Header("Rotation")]
        [SerializeField] private float _maxRotationSpeed = default!;
        [SerializeField] private float _rotationAcceleration = default!;
        [SerializeField] private float _rotationDeAcceleration = default!;

        [Header("MapZoom")]
        [SerializeField] private float _mapMinHeight = default!;
        [SerializeField] private float _mapTurnHeight = default!;
        [SerializeField] private float _mapBasicCameraAngle = default!;
        [SerializeField] private float _mapEndCameraAngle = default!;
        [SerializeField] private float _mapMinZoomScale = default!;
        [SerializeField] private float _mapMaxZoomScale = default!;
        [SerializeField] private float _mapZoomSpeed = default!;

        [Header("CityZoom")]
        [SerializeField] private float _cityMinHeight = default!;
        [SerializeField] private float _cityTurnHeight = default!;
        [SerializeField] private float _cityBasicCameraAngle = default!;
        [SerializeField] private float _cityEndCameraAngle = default!;
        [SerializeField] private float _cityMinZoomScale = default!;
        [SerializeField] private float _cityMaxZoomScale = default!;
        [SerializeField] private float _cityZoomSpeed = default!;

        private CameraFocus _cameraFocus;
        private Vector2 _movementVector;
        private float _movementSpeed;
        private float _rotationVelocity;
        private float _zoomScale;

        private float _minHeight;
        private float _turnHeight;
        private float _basicCameraAngle;
        private float _endCameraAngle;
        private float _minZoomScale;
        private float _maxZoomScale;
        private float _zoomSpeed;

        private Vector3 _lastMapPos;
        private Vector3 _lastCityPos;
        private float _lastMapZoom;
        private float _lastCityZoom;

        private void Awake()
        {
            _eventBus = EngineCore.InjectEventBus();

            this.CheckSerializedField(_cameraRigGameObject, nameof(_cameraRigGameObject));
            this.CheckSerializedField(_camera, nameof(_camera));
            this.CheckSerializedField(_terrain, nameof(_terrain));

            _eventBus.SubscribeWeak<MenuController.ScreenChanged>(this, HandleScreenChange);

            _lastCityPos = _cameraRigGameObject.transform.position;
            _lastCityZoom = _cityMaxZoomScale;
            _lastMapPos = _cameraRigGameObject.transform.position;
            _lastMapZoom = _mapMaxZoomScale;
        }

        private void Update()
        {
            HandleKeys();
            HandleMouseWheel();

            var boost = Input.GetKey(KeyCode.LeftShift) ? _boostModifier : 1;

            _cameraRigGameObject.transform.position +=
                Quaternion.Euler(0, _camera.transform.rotation.eulerAngles.y, 0) * new Vector3(
                    _movementVector.x * _movementSpeed * _zoomScale * Time.deltaTime * boost,
                    0,
                    _movementVector.y * _movementSpeed * _zoomScale * Time.deltaTime * boost);

            var pos = _cameraRigGameObject.transform.position;
            pos.y = _terrain.SampleHeight(pos);
            _cameraRigGameObject.transform.position = pos;


            _cameraRigGameObject.transform.Rotate(Vector3.up, _rotationVelocity * Time.deltaTime);

            Validate();
        }

        private void Validate()
        {
            var pos = _cameraRigGameObject.transform.position;
            var currentBounds = _cameraFocus switch
            {
                CameraFocus.Map => _mapBounds,
                CameraFocus.City => _cityBounds,
                _ => _mapBounds
            };

            if (!currentBounds.Contains(pos))
            {
                _cameraRigGameObject.transform.position = currentBounds.ClosestPoint(pos);
            }
        }

        private void HandleMouseWheel()
        {
            _zoomScale += -Input.mouseScrollDelta.y * _zoomSpeed;
            _zoomScale = Mathf.Clamp(_zoomScale, _minZoomScale, _maxZoomScale);
            MoveCameraPosition();
        }

        private void HandleKeys()
        {
            var direction = new Vector2();

            if (Input.GetKey(KeyCode.W))
            {
                direction.y += 1;
            }
            if (Input.GetKey(KeyCode.S))
            {
                direction.y -= 1;
            }
            if (Input.GetKey(KeyCode.D))
            {
                direction.x += 1;
            }
            if (Input.GetKey(KeyCode.A))
            {
                direction.x -= 1;
            }

            if (direction.magnitude < float.Epsilon)
            {
                if (_movementSpeed < float.Epsilon)
                {
                    _movementSpeed = 0;
                    _movementVector = new Vector2();
                }
                else
                {
                    _movementSpeed -= _movementDeAcceleration * Time.deltaTime;
                    if (_movementSpeed < 0)
                    {
                        _movementSpeed = 0;
                        _movementVector = new Vector2();
                    }
                }
            }
            else
            {
                _movementSpeed += _movementAcceleration * Time.deltaTime;
                if (_movementSpeed > _maxMovementSpeed) _movementSpeed = _maxMovementSpeed;

                _movementVector = Vector2.MoveTowards(_movementVector, direction.normalized, Time.deltaTime * _turnRate);
            }

            if (Input.GetKey(KeyCode.Q))
            {
                _rotationVelocity -= _rotationAcceleration * Time.deltaTime;
            }
            if (Input.GetKey(KeyCode.E))
            {
                _rotationVelocity += _rotationAcceleration * Time.deltaTime;
            }

            if (!Input.GetKey(KeyCode.Q) && !Input.GetKey(KeyCode.E))
            {
                var abs = Mathf.Abs(_rotationVelocity);
                var sign = Mathf.Sign(_rotationVelocity);
                if (abs < float.Epsilon)
                {
                    _rotationVelocity = 0;
                }
                else
                {
                    _rotationVelocity -= _rotationDeAcceleration * Time.deltaTime * sign;
                }

                if (abs > Mathf.Abs(_rotationVelocity))
                {
                    _rotationVelocity = 0;
                }
            }

            _rotationVelocity = _rotationVelocity > _maxRotationSpeed ? _maxRotationSpeed : _rotationVelocity;
            _rotationVelocity = _rotationVelocity < -_maxRotationSpeed ? -_maxRotationSpeed : _rotationVelocity;
        }

        private void HandleScreenChange(MenuController.ScreenChanged message)
        {
            switch (_cameraFocus)
            {
                case CameraFocus.Map:
                    _lastMapPos = _cameraRigGameObject.transform.position;
                    _lastMapZoom = _zoomScale;
                    break;
                case CameraFocus.City:
                    _lastCityPos = _cameraRigGameObject.transform.position;
                    _lastCityZoom = _zoomScale;
                    break;
            }

            _cameraFocus = message.ActiveScreen switch
            {
                ActiveScreen.City => CameraFocus.City,
                ActiveScreen.Map => CameraFocus.Map,
                _ => _cameraFocus
            };

            switch (_cameraFocus)
            {
                case CameraFocus.Map:
                    _minHeight = _mapMinHeight;
                    _turnHeight = _mapTurnHeight;
                    _basicCameraAngle = _mapBasicCameraAngle;
                    _endCameraAngle = _mapEndCameraAngle;
                    _minZoomScale = _mapMinZoomScale;
                    _maxZoomScale = _mapMaxZoomScale;
                    _zoomSpeed = _mapZoomSpeed;
                    break;
                case CameraFocus.City:
                    _minHeight = _cityMinHeight;
                    _turnHeight = _cityTurnHeight;
                    _basicCameraAngle = _cityBasicCameraAngle;
                    _endCameraAngle = _cityEndCameraAngle;
                    _minZoomScale = _cityMinZoomScale;
                    _maxZoomScale = _cityMaxZoomScale;
                    _zoomSpeed = _cityZoomSpeed;
                    break;
                default:
                    throw new ArgumentOutOfRangeException();
            }

            switch (_cameraFocus)
            {
                case CameraFocus.Map:
                    _cameraRigGameObject.transform.position = _lastMapPos;
                    _zoomScale = _lastMapZoom;
                    break;
                case CameraFocus.City:
                    _cameraRigGameObject.transform.position = _lastCityPos;
                    _zoomScale = _lastCityZoom;
                    break;
            }
            _zoomScale = Mathf.Clamp(_zoomScale, _minZoomScale, _maxZoomScale);
        }


        private void MoveCameraPosition()
        {
            _camera.transform.localPosition = new Vector3(0, Mathf.Sin(_basicCameraAngle) * _zoomScale, -Mathf.Cos(_basicCameraAngle) * _zoomScale);

            var currentHeight = _camera.transform.localPosition.y;
            var newCameraAngle = _basicCameraAngle;
            if (currentHeight < _turnHeight)
            {
                var endPhase = Mathf.Clamp((_turnHeight - currentHeight) / (_turnHeight - _minHeight), 0, 1);
                newCameraAngle -= (_basicCameraAngle - _endCameraAngle) * endPhase;
                _camera.transform.localPosition =
                    new Vector3(0, _camera.transform.localPosition.y + _minHeight * endPhase * endPhase, _camera.transform.localPosition.z);
            }
            _camera.transform.localRotation = Quaternion.Euler(newCameraAngle, 0, 0);
        }
    }
}
