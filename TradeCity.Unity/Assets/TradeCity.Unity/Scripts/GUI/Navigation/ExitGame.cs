using UnityEngine;
using UnityEngine.UI;

namespace TradeCity.Unity.Scripts.GUI.Navigation
{
    [RequireComponent(typeof(Button))]
    public class ExitGame : MonoBehaviour
    {
        private void Awake()
        {
            GetComponent<Button>().onClick.AddListener(OnClick);
        }

        private void OnClick()
        {
            Application.Quit();
        }
    }
}
