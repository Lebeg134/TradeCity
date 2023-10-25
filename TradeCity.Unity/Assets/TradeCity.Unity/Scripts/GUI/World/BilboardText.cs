using AutSoft.UnitySupplements.Vitamins;
using UnityEngine;

namespace TradeCity.Unity.Scripts.GUI.World
{
    public class BillboardText : MonoBehaviour
    {
        [SerializeField] private Camera _mainCamera = default!;

        void Awake()
        {
            this.CheckSerializedField(_mainCamera, nameof(_mainCamera));
        }

        void Start()
        {
            _mainCamera = Camera.main;
        }

        void Update()
        {
            transform.rotation = _mainCamera.transform.rotation;
        }
    }
}