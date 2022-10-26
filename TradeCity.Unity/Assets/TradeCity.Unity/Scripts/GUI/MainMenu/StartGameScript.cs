using TradeCity.Engine.Session;
using TradeCity.Engine.Session.Templates;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

namespace TradeCity.Unity.Scripts.GUI.MainMenu
{
    [RequireComponent(typeof(Button))]
    public class StartGameScript : MonoBehaviour
    {
        private Button _newGameBtn = default!;

        private void Awake()
        {
            _newGameBtn = GetComponent<Button>();

            _newGameBtn.onClick.AddListener(StartGame);
        }

        private void OnDestroy()
        {
            _newGameBtn.onClick.RemoveListener(StartGame);
        }

        private static void StartGame()
        {
            var session = SessionGenerator.Generate(new CampaignTemplate());
            session.Start();
            SceneManager.LoadScene(sceneName: "GameScene");
        }
    }
}
