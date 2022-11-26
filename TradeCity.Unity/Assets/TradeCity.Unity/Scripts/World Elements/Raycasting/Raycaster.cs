using System.Collections.Generic;
using UnityEngine;

namespace TradeCity.Unity.Scripts.World_Elements.Raycasting
{
    public class Raycaster: MonoBehaviour
    {
        [SerializeField]
        private List<GameObject> _raycastTargets = new();

        public bool Enabled = false;
        
        public void Update()
        {
            if (!Input.GetMouseButtonDown(0)) return;
            Debug.Log("clicked");
            var ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            if (!Physics.Raycast(ray, out var raycastHit, 100f, 0)) return;
            if (raycastHit.transform != null)
            {
                Debug.Log("found gameObject: " + raycastHit.transform.gameObject);
                raycastHit.transform.gameObject.GetComponentInParent<IRaycastTarget>().OnClick(this);
            }
        }

    }
}
