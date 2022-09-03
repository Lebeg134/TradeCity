using TradeCity.Engine.Session;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

namespace TradeCity.Unity.Scripts.GUI.MainMenu
{
    public class StartGameScript : MonoBehaviour
    {
        public Button newGameBtn;
        // Start is called before the first frame update
        void Start()
        {
            newGameBtn.onClick.AddListener(() => StartGame());
        }

        private void StartGame()
        {
            SceneManager.LoadScene(sceneName: "GameScene");
            Session session = SessionGenerator.GenerateStandard();
            session.Start();
        }

        // Update is called once per frame
        void Update()
        {

        }
    }
}
