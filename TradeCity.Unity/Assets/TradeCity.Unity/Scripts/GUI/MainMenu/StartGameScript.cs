using AutSoft.UnitySupplements.Vitamins;
using TradeCity.Engine.Session;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

namespace TradeCity.Unity.Scripts.GUI.MainMenu
{
    public class StartGameScript : MonoBehaviour
    {
        [SerializeField] private Button newGameBtn;

        private void Awake()
        {
            this.CheckSerializedField(newGameBtn, nameof(newGameBtn));

            newGameBtn.onClick.AddListener(StartGame);
        }

        private void OnDestroy()
        {
            newGameBtn.onClick.RemoveListener(StartGame);
        }

        private void StartGame()
        {
            SceneManager.LoadScene(sceneName: "GameScene");
            Session session = SessionGenerator.GenerateStandard();
            session.Start();
        }
    }
}
