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
        [SerializeField] private Button _button = default!;

        private void Awake()
        {
            this.CheckSerializedField(_button, nameof(_button));
        }

        private void Start()
        {
            _button = GetComponent<Button>();
            UpdateVisuals();
            _button.onClick.AddListener(() => OnClick());
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
                _button.interactable = false;
            }
        }

        private void Update()
        {
            UpdateVisuals();
        }

        private void UpdateVisuals()
        {
            _button.interactable = Session.SaveExists();
        }
    }
}
