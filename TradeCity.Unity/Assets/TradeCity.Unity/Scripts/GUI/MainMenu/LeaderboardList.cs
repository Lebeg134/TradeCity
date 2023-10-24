using System;
using System.Collections.Generic;
using System.Linq;
using AutSoft.UnitySupplements.Vitamins;
using TMPro;
using TradeCity.Unity.Scripts.Leaderboard;
using UnityEngine;

namespace TradeCity.Unity.Scripts.GUI.MainMenu
{
    public class LeaderboardList: SimpleList<Score, LeaderboardListItem>
    {
        [SerializeField] private WebService _webService = default!;
        [SerializeField] private TMP_Text _loadingText = default!;
        [SerializeField] private TMP_Text _loadFailText = default!;

        private List<Score> _scores;

        protected override void Awake()
        {
            base.Awake();
            this.CheckSerializedField(_webService, nameof(_webService));
            this.CheckSerializedField(_loadingText, nameof(_loadingText));
            this.CheckSerializedField(_loadFailText, nameof(_loadFailText));
        }

        protected override void Start()
        {
            base.Start();
            _loadingText.gameObject.SetActive(true);
            _loadFailText.gameObject.SetActive(false);
            StartCoroutine(_webService.GetScores(HandleResponse, HandleError));
        }

        private void HandleResponse(List<Score> scores)
        {
            _scores = scores;
            _loadingText.gameObject.SetActive(false);
            Refresh();

        }

        private void HandleError()
        {
            _loadingText.gameObject.SetActive(false);
            _loadFailText.gameObject.SetActive(true);
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