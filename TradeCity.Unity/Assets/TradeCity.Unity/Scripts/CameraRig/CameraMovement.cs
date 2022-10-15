using System.Diagnostics.CodeAnalysis;
using AutSoft.UnitySupplements.Vitamins;
using UnityEngine;
using UnityEngine.UIElements;

namespace TradeCity.Unity.Scripts.CameraRig
{
    public class CameraMovement : MonoBehaviour
    {
        [SerializeField] private GameObject _focusPointObject = default!;
        [SerializeField] private GameObject _cameraRigGameObject = default!;
        [SerializeField] private Camera _camera;

        [Header("Movement")]
        [SerializeField] private float _maxMovementSpeed = default!;
        [SerializeField] private float _movementAcceleration = default!;
        [SerializeField] private float _turnRate = default!;
        [SerializeField] private float _movementDeAcceleration = default;

        [Header("Rotation")]
        [SerializeField] private float _maxRotationSpeed = default!;
        [SerializeField] private float _rotationAcceleration = default!;
        [SerializeField] private float _rotationDeAcceleration = default!;

        [Header("Zoom")]
        [SerializeField] private float _minHeight = default!;
        [SerializeField] private float _turnHeight = default!;
        [SerializeField] private float _basicCameraAngle = default!;
        [SerializeField] private float _minZoomScale = default!;
        [SerializeField] private float _maxZoomScale = default!;
        [SerializeField] private float _zoomSpeed = default!;
        
        private Vector2 _movementVector;
        private float _movementSpeed;
        private float _rotationVelocity;
        private float _zoomScale = 1f;

        private void Awake()
        {
            this.CheckSerializedField(_focusPointObject, nameof(_focusPointObject));
            this.CheckSerializedField(_cameraRigGameObject, nameof(_cameraRigGameObject));
            this.CheckSerializedField(_camera, nameof(_camera));
        }

        private void Update()
        {
            HandleKeys();
            HandleMouseWheel();


            _cameraRigGameObject.transform.position += Quaternion.Euler(0, _camera.transform.rotation.eulerAngles.y, 0) *
                                                       new Vector3(_movementVector.x * _movementSpeed * _zoomScale * Time.deltaTime,
                                                              0, _movementVector.y * _movementSpeed * _zoomScale * Time.deltaTime);
            _cameraRigGameObject.transform.Rotate(Vector3.up, _rotationVelocity);
        }

        private void HandleMouseWheel()
        {
            _zoomScale += -Input.mouseScrollDelta.y*_zoomSpeed;
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
                _rotationVelocity += _rotationAcceleration * Time.deltaTime;
            }
            if (Input.GetKey(KeyCode.E))
            {
                _rotationVelocity -= _rotationAcceleration * Time.deltaTime;
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


        private void MoveCameraPosition()
        {
            _camera.transform.localPosition = new Vector3(0, Mathf.Sin(_basicCameraAngle)*_zoomScale, -Mathf.Cos(_basicCameraAngle)*_zoomScale);

            var currentHeight = _camera.transform.localPosition.y;
            var newCameraAngle =  _basicCameraAngle;
            if (currentHeight < _turnHeight)
            {
                var endPhase = (_turnHeight - currentHeight) / (_turnHeight - _minHeight);
                newCameraAngle -= _basicCameraAngle * endPhase;
                _camera.transform.localPosition =
                    new Vector3(0, _camera.transform.localPosition.y + _minHeight * endPhase, _camera.transform.localPosition.z);
            }
            _camera.transform.localRotation = Quaternion.Euler(newCameraAngle, 0, 0);
        }
    }
}
