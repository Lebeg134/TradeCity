using UnityEngine;
using UnityEngine.UI;

namespace TradeCity.Unity.Scripts.GUI.Missions
{
    public class MissionButtonScript : MonoBehaviour
    {
        public ScrollRect scrollView;
        public Button missionButton;
        bool isShown = false;
        void Start()
        {
            if (scrollView == null)
                scrollView = GetComponent<ScrollRect>();
            if (missionButton == null )
                missionButton = GetComponent<Button>();
            missionButton.onClick.AddListener(OnClick);
        }

        private void OnClick()
        {
            isShown = !isShown;
            scrollView.gameObject.SetActive(isShown);
        }

        // Update is called once per frame
        void Update()
        {
        
        }
    }
}
