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
        private void Start()
        {
            GetComponent<Button>().onClick.AddListener(() =>
            {
                Clock.Instance.Pause();
                Session.Save();
                SceneManager.LoadScene(sceneName: "MainMenu");
            });
        }

        private void OnApplicationQuit()
        {
            Clock.Instance.Pause();
        }
    }
}
