using System.Collections.Generic;
using AutSoft.UnitySupplements.Vitamins;
using TradeCity.Unity.Scripts.GUI;
using TradeCity.Unity.Scripts.Leaderboard;
using UnityEngine;

namespace TradeCity.Unity.Scripts.GUI.MainMenu
{
    public class LeaderboardList: SimpleList<Score, LeaderboardListItem>
    {
        [SerializeField] private WebService _webService = default!;

        protected override void Awake()
        {
            base.Awake();
            this.CheckSerializedField(_webService, nameof(_webService));
        }

        protected override void ProcessListItem(Score item, LeaderboardListItem newListItem)
        {
            newListItem.SetScore(item);
        }

        protected override IEnumerable<Score> GetCollection()
        {
            try
            {
                return _webService.GetScores();
            }
            catch
            {
                //TODO display on UI
                return new List<Score>();
            }
        }
    }
}