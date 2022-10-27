using Injecter;
using TradeCity.Engine.Core;
using TradeCity.Engine.Core.Interfaces;
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
        [Inject] private ISessionService _sessionService;

        private Button _newGameBtn = default!;

        private void Awake()
        {
            _sessionService = EngineCore.InjectSessionService();
            _newGameBtn = GetComponent<Button>();

            _newGameBtn.onClick.AddListener(StartGame);
        }

        private void OnDestroy()
        {
            _newGameBtn.onClick.RemoveListener(StartGame);
        }

        private void StartGame()
        {
            var session = SessionGenerator.Generate(new CampaignTemplate());
            _sessionService.SwitchToSession(session);
            session.Start();
            SceneManager.LoadScene(sceneName: "GameScene");
        }
    }
}
