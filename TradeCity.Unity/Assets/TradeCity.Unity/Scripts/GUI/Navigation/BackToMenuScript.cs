using TradeCity.Engine.Session;
using TradeCity.Engine.TimeManager;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

namespace TradeCity.Unity.Scripts.GUI.Navigation
{
    public class BackToMenuScript : MonoBehaviour
    {
        // Start is called before the first frame update
        void Start()
        {
            GetComponent<Button>().onClick.AddListener(() =>
            {
                Clock.Instance.Pause();
                Session.Save();
                SceneManager.LoadScene(sceneName: "MainMenu");
            });
        }
        // Update is called once per frame
        void Update()
        {

        }
        private void OnApplicationQuit()
        {
            Clock.Instance.Pause();
        }
    }
}
