using System;
using Injecter;
using TradeCity.Engine.Core;
using TradeCity.Engine.Core.Interfaces;
using TradeCity.Engine.Session;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

namespace TradeCity.Unity.Scripts.GUI.MainMenu
{
    [RequireComponent(typeof(Button))]
    public class ContinueButton : MonoBehaviour
    {
        [Inject] private ISessionService _sessionService;
        private Button _button = default!;

        private void Awake()
        {
            _sessionService = EngineCore.InjectSessionService();
            _button = GetComponent<Button>();
        }

        private void Start()
        {
            _button = GetComponent<Button>();
            UpdateVisuals();
            _button.onClick.AddListener(OnClick);
        }

        private void OnClick()
        {
            try
            {
                _sessionService.Load("NewSave");
                SceneManager.LoadScene(sceneName: "GameScene");
                _sessionService.CurrentSession.Start();
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
            _button.interactable = _sessionService.SaveExists();
        }
    }
}
