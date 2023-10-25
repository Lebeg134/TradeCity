using AutSoft.UnitySupplements.EventBus;
using System;
using Injecter;
using TradeCity.Engine.Structures;
using UnityEngine;
using TradeCity.Engine.Core;
using TradeCity.Engine.Core.Interfaces;
using System.Linq;
using System.Collections.Generic;

namespace TradeCity.Unity.Scripts.World_Elements.Buildings
{
    public class BuildingPrefab : MonoBehaviour
    {
        [Inject] private IEventBus _eventBus;
        [Inject] private IPlayerService _playerService;
        [Inject] private ISessionService _sessionService;


        [SerializeField] private List<GameObject> _showGameObjects = default!;
        [SerializeField] private List<GameObject> _hideGameObjects = default!;

        [SerializeField] private String _initName;

        private Building _focusBuilding;

        private void Awake()
        {
            _eventBus = EngineCore.InjectEventBus();
            _playerService = EngineCore.InjectPlayerService();
            _sessionService = EngineCore.InjectSessionService();

            _eventBus.Subscribe<Building.BuildingBuilt>(building =>
            {
                if (building.Building.GetName() != _initName) return;
                _focusBuilding = building.Building;
                UpdateVisuals();
            });

            _eventBus.Subscribe<CommonStructure.StructureUpgraded>(building =>
            {
                if (building.Subject == _focusBuilding) UpdateVisuals();
            });
        }

        private void Start()
        {
            gameObject.SetActive(false);
        }

        private void UpdateVisuals()
        {
            var level = _focusBuilding.Level;

            gameObject.SetActive(level != 0);

            for (var i = 0; i < _showGameObjects.Count; i++)
            {
                _showGameObjects[i].SetActive(i < level);
            }
            for (var i = 0; i < _hideGameObjects.Count; i++)
            {
                _hideGameObjects[i].SetActive(i >= level);
            }
        }
    }
}