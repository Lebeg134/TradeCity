using System.Diagnostics.CodeAnalysis;
using AutSoft.UnitySupplements.Vitamins;
using UnityEngine;

namespace TradeCity.Unity.Scripts.CameraRig
{
    [RequireComponent(typeof(Camera))]
    public class CameraMovement : MonoBehaviour
    {
        [SerializeField] private GameObject _focusPointObject = default!;
        [SerializeField] private GameObject _cameraRigGameObject = default!;
        [Header("Movement")]
        [SerializeField] private float _maxMovementSpeed = default!;
        [SerializeField] private float _movementAcceleration = default!;
        [SerializeField] private float _turnRate = default!;
        [SerializeField] private float _movementDeAcceleration = default;
        [Header("Rotation")]
        [SerializeField] private float _maxRotationSpeed = default!;
        [SerializeField] private float _rotationAcceleration = default!;
        [SerializeField] private float _rotationDeAcceleration = default!;
        


        private Camera _camera;
        private Vector2 _movementVector;
        private float _movementSpeed;
        private float _rotationVelocity;

        private void Awake()
        {
            _camera = GetComponent<Camera>();
            this.CheckSerializedField(_focusPointObject, nameof(_focusPointObject));
            this.CheckSerializedField(_cameraRigGameObject, nameof(_cameraRigGameObject));
        }

        private void Update()
        {
            HandleKeys();

            _cameraRigGameObject.transform.position += Quaternion.Euler(0, _camera.transform.rotation.eulerAngles.y, 0) *
                                                       new Vector3(_movementVector.x * _movementSpeed * Time.deltaTime,
                                                              0, _movementVector.y * _movementSpeed * Time.deltaTime);
            RotateAroundMiddle(_rotationVelocity);
        }

        private void HandleKeys()
        {
            var offset = _camera.transform.rotation;

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
                    _movementSpeed -= _movementDeAcceleration*Time.deltaTime;
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

            if (!Input.GetKey(KeyCode.W) && !Input.GetKey(KeyCode.S) && 
                !Input.GetKey(KeyCode.D) && !Input.GetKey(KeyCode.A))
            {
                // nothing TODO remove this if not needed
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

        private void RotateAroundMiddle(float angle)
        {
            var relative = _camera.transform.position - _focusPointObject.transform.position;
            var rotation = Quaternion.Euler(new Vector3(0, angle, 0));

            _camera.transform.position = rotation * relative + _focusPointObject.transform.position;
            _camera.transform.eulerAngles = rotation.eulerAngles + _camera.transform.rotation.eulerAngles;
        }
    }
}
