using AutSoft.UnitySupplements.EventBus;
using AutSoft.UnitySupplements.Vitamins;
using Injecter;
using TradeCity.Engine.Core;
using TradeCity.Unity.Scripts.GUI.Navigation;
using UnityEngine;

namespace TradeCity.Unity.Scripts.Audio
{
    [RequireComponent(typeof(AudioSource))]
    public class AmbientAudio : MonoBehaviour
    {
        [Inject] private IEventBus _eventBus = default!;

        [SerializeField] private MenuController _screenNavigator = default!;
        [SerializeField] private AudioClip _cityAmbient = default!;
        [SerializeField] private AudioClip _mapAmbient = default!;
        [SerializeField] private AudioClip _marketAmbient = default!;

        private AudioSource _audioSource = default!;

        private void Awake()
        {
            _eventBus = EngineCore.InjectEventBus();

            this.CheckSerializedField(_screenNavigator, nameof(_screenNavigator));
            this.CheckSerializedField(_cityAmbient, nameof(_cityAmbient));
            this.CheckSerializedField(_mapAmbient, nameof(_mapAmbient));
            this.CheckSerializedField(_marketAmbient, nameof(_marketAmbient));

            _audioSource = GetComponent<AudioSource>();
        }

        private void Start()
        {
            _audioSource = GetComponent<AudioSource>();
            _eventBus.SubscribeWeak<MenuController.ScreenChanged>(this, OnScreenChange);
        }

        private void OnScreenChange(MenuController.ScreenChanged message)
        {
            switch (message.ActiveScreen)
            {
                case ActiveScreen.City:
                    _audioSource.clip = _cityAmbient;
                    break;
                case ActiveScreen.Map:
                    _audioSource.clip = _mapAmbient;
                    break;
                case ActiveScreen.Market:
                    _audioSource.clip = _marketAmbient;
                    break;

            }
            _audioSource.Play();
        }
    }
}