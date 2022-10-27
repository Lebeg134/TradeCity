using Injecter;
using TradeCity.Engine.Core;
using TradeCity.Engine.Core.Interfaces;
using TradeCity.Engine.Session;
using TradeCity.Engine.TimeManager;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

namespace TradeCity.Unity.Scripts.GUI.Navigation
{
    [RequireComponent(typeof(Button))]
    public class BackToMenu : MonoBehaviour
    {
        [Inject] private ISessionService _sessionService;
        [Inject] private IClock _clock;

        private void Awake()
        {
            _sessionService = EngineCore.InjectSessionService();
            _clock = EngineCore.InjectClock();
        }

        private void Start()
        {
            GetComponent<Button>().onClick.AddListener(() =>
            {
                _clock.Pause();
                _sessionService.CurrentSession.Save();
                SceneManager.LoadScene(sceneName: "MainMenu");
            });
        }

        private void OnApplicationQuit()
        {
            _clock.Pause();
        }
    }
}
