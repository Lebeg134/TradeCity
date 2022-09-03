using UnityEngine;

namespace TradeCity.Unity.Scripts.GUI.VisualUpdaters
{
    public class VisualUpdater : MonoBehaviour, IVisualUpdateable
    {
        public GameObject target;

        public void VisualUpdate()
        {
            target.GetComponent<IVisualUpdateable>().VisualUpdate();
        }
        void Start() { }
        void Update() { }


    }
}
