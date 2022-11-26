using System.Collections.Generic;
using AutSoft.UnitySupplements.EventBus;
using AutSoft.UnitySupplements.Vitamins;
using Injecter;
using Mono.Cecil;
using TradeCity.Engine.Core;
using TradeCity.Engine.Structures;
using TradeCity.Units.Structures.Lands;
using TradeCity.Unity.Scripts.World_Elements.Raycasting;
using UnityEngine;

namespace TradeCity.Unity.Scripts.World_Elements.Lands
{
    public class CampaignLandPrefab : MonoBehaviour, IRaycastTarget
    {
        [Inject] private IEventBus _eventBus;

        [SerializeField] private List<GameObject> _showGameObjects = default!;
        [SerializeField] private List<GameObject> _hideGameObjects = default!;

        private Land _focusLand;

        private void Awake()
        {
            _eventBus = EngineCore.InjectEventBus();
        }

        public void SetFocus(Land land)
        {
            _focusLand = land;
            UpdateVisuals();
        }

        private void UpdateVisuals()
        {
            var level = _focusLand.Level;
            for (var i = 0; i < _showGameObjects.Count; i++)
            {
                _showGameObjects[i].SetActive(i < level);
            }
            for (var i = 0; i < _hideGameObjects.Count; i++)
            {
                _hideGameObjects[i].SetActive(i >= level);
            }
        }

        public void OnClick(Raycaster raycaster)
        {
            Debug.Log("clicked on gameObject: "+this);
            

        }
    }
}
