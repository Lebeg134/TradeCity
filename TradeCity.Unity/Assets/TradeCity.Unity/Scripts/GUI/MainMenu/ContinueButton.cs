using AutSoft.UnitySupplements.Vitamins;
using System;
using TradeCity.Engine.Session;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

namespace TradeCity.Unity.Scripts.GUI.MainMenu
{
    public class ContinueButton : MonoBehaviour
    {
        [SerializeField] private Button button;

        private void Awake()
        {
            this.CheckSerializedField(button, nameof(button));
        }

        private void Start()
        {
            button = GetComponent<Button>();
            UpdateVisuals();
            button.onClick.AddListener(() => OnClick());
        }

        private void OnClick()
        {
            try
            {
                Session.Load();
                SceneManager.LoadScene(sceneName: "GameScene");
                Session.Instance.Start();
            }
            catch (Exception)
            {
                button.interactable = false;
            }
        }

        void Update() => UpdateVisuals();

        void UpdateVisuals()
        {
            button.interactable = Session.SaveExists();
        }
    }
}
