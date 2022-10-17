using Injecter;
using TradeCity.Engine.Core;
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
        [Inject]
        private IClock _clock;

        private void Awake()
        {
            _clock = EngineCore.Instance.InjectClock();
        }

        private void Start()
        {
            GetComponent<Button>().onClick.AddListener(() =>
            {
                _clock.Pause();
                Session.Save();
                SceneManager.LoadScene(sceneName: "MainMenu");
            });
        }

        private void OnApplicationQuit()
        {
            _clock.Pause();
        }
    }
}
