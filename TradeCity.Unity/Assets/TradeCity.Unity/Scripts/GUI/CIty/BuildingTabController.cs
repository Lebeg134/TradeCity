using AutSoft.UnitySupplements.Vitamins;
using System.Linq;
using Injecter;
using TradeCity.Engine.Core;
using TradeCity.Engine.Core.Interfaces;
using TradeCity.Engine.Session;
using TradeCity.Engine.Structures;
using TradeCity.Units;
using UnityEngine;
using UnityEngine.UI;

namespace TradeCity.Unity.Scripts.GUI.CIty
{
    public class BuildingTabController : MonoBehaviour
    {
        [Inject] private IPlayerService _playerService;
        [Inject] private ISessionService _sessionService;

        [SerializeField] private Button _commonBranch = default!;
        [SerializeField] private Button _constructionBranch = default!;
        [SerializeField] private Button _energyBranch = default!;
        [SerializeField] private Button _oilBranch = default!;
        [SerializeField] private Button _workforceBranch = default!;
        [SerializeField] private GameObject _content = default!;
        [SerializeField] private GameObject _buildingListItemPrefab = default!;

        private Branches _active = Branches.Common;

        private void Awake()
        {
            _playerService = EngineCore.InjectPlayerService();
            _sessionService = EngineCore.InjectSessionService();

            this.CheckSerializedField(_commonBranch, nameof(_commonBranch));
            this.CheckSerializedField(_constructionBranch, nameof(_constructionBranch));
            this.CheckSerializedField(_energyBranch, nameof(_energyBranch));
            this.CheckSerializedField(_oilBranch, nameof(_oilBranch));
            this.CheckSerializedField(_workforceBranch, nameof(_workforceBranch));
            this.CheckSerializedField(_content, nameof(_content));
            this.CheckSerializedField(_buildingListItemPrefab, nameof(_buildingListItemPrefab));

            _commonBranch.onClick.AddListener(() => Switch(Branches.Common));
            _constructionBranch.onClick.AddListener(() => Switch(Branches.Construction));
            _energyBranch.onClick.AddListener(() => Switch(Branches.Energy));
            _oilBranch.onClick.AddListener(() => Switch(Branches.Oil));
            _workforceBranch.onClick.AddListener(() => Switch(Branches.Workforce));
        }

        private void Start()
        {
            Switch(Branches.Construction);
        }

        private void OnDestroy()
        {
            _commonBranch.onClick.RemoveAllListeners();
            _constructionBranch.onClick.RemoveAllListeners();
            _energyBranch.onClick.RemoveAllListeners();
            _oilBranch.onClick.RemoveAllListeners();
            _workforceBranch.onClick.RemoveAllListeners();
        }

        private void Switch(Branches tab)
        {
            GetBranchButton(_active).interactable = true;
            GetBranchButton(tab).interactable = false;
            _active = tab;
            for (var i = 0; i < _content.transform.childCount; i++)
            {
                Destroy(_content.transform.GetChild(i).gameObject);
            }
            RegisterAllBuildings(tab);
        }

        private void RegisterBuilding(Building building)
        {
            var listItem = Instantiate(_buildingListItemPrefab);
            listItem.GetComponent<BuildingListItem>().Building = building.GetName();
            listItem.transform.SetParent(_content.transform);
        }

        private void RegisterAllBuildings(Branches branch) //TODO add player checks
        {
            if (_playerService.CurrentPlayer == null) return;

            foreach (var building in _playerService.CurrentPlayer.GetAllBuildings()
                         .Where(building => building.GetBranch() == branch))
            {
                RegisterBuilding(building);
            }

            foreach (var building in _sessionService.GetAllBuildings()
                         .Where(building => building.GetBranch() == branch && !_playerService.CurrentPlayer.HasStructure(building)))
            {
                RegisterBuilding(building);
            }
        }
        private Button GetBranchButton(Branches branch)
        {
            return branch switch
            {
                Branches.Common => _commonBranch,
                Branches.Construction => _constructionBranch,
                Branches.Energy => _energyBranch,
                Branches.Oil => _oilBranch,
                Branches.Workforce => _workforceBranch,
                _ => null
            };
        }
    }
}