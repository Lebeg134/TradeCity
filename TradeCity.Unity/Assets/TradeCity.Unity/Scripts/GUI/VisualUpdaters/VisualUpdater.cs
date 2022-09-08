using AutSoft.UnitySupplements.Vitamins;
using UnityEngine;

namespace TradeCity.Unity.Scripts.GUI.VisualUpdaters
{
    public class VisualUpdater : MonoBehaviour, IVisualUpdateable
    {
        [SerializeField] private GameObject _target = default!;

        private void Awake()
        {
            this.CheckSerializedField(_target, nameof(_target));
        }

        public void VisualUpdate()
        {
            _target.GetComponent<IVisualUpdateable>().VisualUpdate();
        }
    }
}
