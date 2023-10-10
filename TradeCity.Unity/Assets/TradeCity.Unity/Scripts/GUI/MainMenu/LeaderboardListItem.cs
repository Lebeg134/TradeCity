using AutSoft.UnitySupplements.Vitamins;
using TMPro;
using UnityEngine;

using TradeCity.Unity.Scripts.Leaderboard;

namespace TradeCity.Unity.Scripts.GUI.MainMenu
{
    public class LeaderboardListItem: MonoBehaviour
    {
        [SerializeField] private TMP_Text _userNameDisplay = default!;
        [SerializeField] private TMP_Text _scoreDisplay = default!;

        public void Awake()
        {
            this.CheckSerializedField(_userNameDisplay, nameof(_userNameDisplay));
            this.CheckSerializedField(_scoreDisplay, nameof(_scoreDisplay));
        }

        public void SetScore(Score score)
        {
            _userNameDisplay.text = score.username;
            _scoreDisplay.text = score.score.ToString();
        }
    }
}