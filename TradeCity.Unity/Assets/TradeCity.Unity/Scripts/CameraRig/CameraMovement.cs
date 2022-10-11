using AutSoft.UnitySupplements.Vitamins;
using UnityEngine;

namespace TradeCity.Unity.Scripts.CameraRig
{
    [RequireComponent(typeof(Camera))]
    public class CameraMovement: MonoBehaviour
    {
        [SerializeField] private GameObject _focusPointObject = default!;
        [SerializeField] private Vector3 _maxMovementSpeed;
        [SerializeField] private Vector3 _movementAcceleration;
        [SerializeField] private float _maxRotationSpeed;
        [SerializeField] private float _rotationAcceleration;

        private Camera _camera;
        private Vector3 _movementVelocity;
        private float _rotationVelocity;

        private void Awake()
        {
            _camera = GetComponent<Camera>();
            this.CheckSerializedField(_focusPointObject, nameof(_focusPointObject));
        }

        private void Update()
        {
            if (Input.anyKey) HandleKeys();
        }

        private void HandleKeys()
        {
            var offset = _camera.transform.forward;
            offset.y = 0;
            offset = offset.normalized* 0.01f;

            const float defaultAngle = 0.1f;
            if (Input.GetKey(KeyCode.W))
            {
                _camera.transform.position += offset;
            }
            if (Input.GetKey(KeyCode.S))
            {
                _camera.transform.position -= offset;
            }
            if (Input.GetKey(KeyCode.A))
            {
                _camera.transform.position += new Vector3(-offset.z, 0, offset.x);
            }
            if (Input.GetKey(KeyCode.D))
            {
                _camera.transform.position -= new Vector3(-offset.z, 0, offset.x);
            }
            if (Input.GetKey(KeyCode.Q))
            {
                RotateAroundMiddle(defaultAngle);
            }
            if (Input.GetKey(KeyCode.E))
            {
                RotateAroundMiddle(-defaultAngle);
            }
        }

        private void RotateAroundMiddle(float angle)
        {
            var relative = _camera.transform.position - _focusPointObject.transform.up;
            var rotation = Quaternion.Euler(new Vector3(0, angle, 0));
            relative = rotation * relative;
            _camera.transform.position =  relative + _focusPointObject.transform.position;
            //_camera.transform.forward = rotation * _camera.transform.forward;
        }
    }
}
