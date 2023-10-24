using System;
using System.Collections.Generic;
using System.Linq;
using AutSoft.UnitySupplements.EventBus;
using AutSoft.UnitySupplements.Vitamins;
using Injecter;
using TradeCity.Engine.Core;
using TradeCity.Engine.Core.Interfaces;
using TradeCity.Engine.Session;
using TradeCity.Engine.Structures;
using UnityEngine;
using UnityEngine.EventSystems;

namespace TradeCity.Unity.Scripts.World_Elements.Lands
{
    public class CampaignLandPrefab : MonoBehaviour, IPointerClickHandler
    {
        [Inject] private IEventBus _eventBus;
        [Inject] private IPlayerService _playerService;
        [Inject] private ISessionService _sessionService;

        [SerializeField] private List<GameObject> _showGameObjects = default!;
        [SerializeField] private List<GameObject> _hideGameObjects = default!;
        [SerializeField] private String _initName;

        private Land _focusLand;

        private void Awake()
        {
            _eventBus = EngineCore.InjectEventBus();
            _playerService = EngineCore.InjectPlayerService();
            _sessionService = EngineCore.InjectSessionService();

            _focusLand = _sessionService.CurrentSession
                .GetAllLands().FirstOrDefault(land => land.GetName() == _initName);
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

        public void OnPointerClick(PointerEventData eventData)
        {
            _eventBus.Invoke(new LandClicked(_focusLand, _playerService.CurrentPlayer));
        }

        public class LandClicked : IEvent
        {
            public LandClicked(Land land, Player byPlayer)
            {
                Land = land;
                Player = byPlayer;
            }

            public Land Land { get; }
            public Player Player { get; }
        }
    }
}
