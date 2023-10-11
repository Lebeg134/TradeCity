using System;
using System.Collections.Generic;
using AutSoft.UnitySupplements.Vitamins;
using MoreLinq.Extensions;
using TradeCity.Unity.Scripts.GUI;
using TradeCity.Unity.Scripts.Leaderboard;
using UnityEngine;

namespace TradeCity.Unity.Scripts.GUI.MainMenu
{
    public class LeaderboardList: SimpleList<Score, LeaderboardListItem>
    {
        [SerializeField] private WebService _webService = default!;

        private List<Score> _scores = new List<Score>();

        protected override void Awake()
        {
            base.Awake();
            this.CheckSerializedField(_webService, nameof(_webService));
        }

        protected override void Start()
        {
            base.Start();
            //TODO show loading
            StartCoroutine(_webService.GetScores(HandleResponse, HandleError));
        }

        private void HandleResponse(List<Score> scores)
        {
            Refresh();
            //TODO Hide loading

        }

        private void HandleError()
        {
            //TODO display error thingy
        }

        protected override void ProcessListItem(Score item, LeaderboardListItem newListItem)
        {
            newListItem.SetScore(item);
        }

        protected override IEnumerable<Score> GetCollection()
        {
            return _scores;
        }
    }
}