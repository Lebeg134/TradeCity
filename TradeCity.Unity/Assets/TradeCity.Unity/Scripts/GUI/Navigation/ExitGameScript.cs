using UnityEngine;
using UnityEngine.UI;

namespace TradeCity.Unity.Scripts.GUI.Navigation
{
    public class ExitGameScript : MonoBehaviour
    {
        public Button exitButton;
        // Start is called before the first frame update
        void Start()
        {
            exitButton.onClick.AddListener(() => ExitGame());
        }

        private void ExitGame()
        {
            Application.Quit();
        }

        // Update is called once per frame
        void Update()
        {

        }
    }
}
