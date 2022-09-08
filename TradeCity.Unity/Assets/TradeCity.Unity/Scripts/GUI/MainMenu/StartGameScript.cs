using AutSoft.UnitySupplements.Vitamins;
using TradeCity.Engine.Session;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

namespace TradeCity.Unity.Scripts.GUI.MainMenu
{
    public class StartGameScript : MonoBehaviour
    {
        [SerializeField] private Button _newGameBtn = default!;

        private void Awake()
        {
            this.CheckSerializedField(_newGameBtn, nameof(_newGameBtn));

            _newGameBtn.onClick.AddListener(StartGame);
        }

        private void OnDestroy()
        {
            _newGameBtn.onClick.RemoveListener(StartGame);
        }

        private void StartGame()
        {
            SceneManager.LoadScene(sceneName: "GameScene");
            Session session = SessionGenerator.GenerateStandard();
            session.Start();
        }
    }
}
