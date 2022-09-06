using AutSoft.UnitySupplements.Vitamins;
using TradeCity.Unity.Scripts.GUI.Navigation;
using UnityEngine;

namespace TradeCity.Unity.Scripts.Audio
{
    [RequireComponent(typeof(AudioSource))]
    public class AmbientAudio : MonoBehaviour
    {
        [SerializeField] private MenuController _screenNavigator = default!;
        [SerializeField] private AudioClip _cityAmbient = default!;
        [SerializeField] private AudioClip _mapAmbient = default!;
        [SerializeField] private AudioClip _marketAmbient = default!;

        private AudioSource _audioSource = default!;

        private void Awake()
        {
            this.CheckSerializedField(_screenNavigator, nameof(_screenNavigator));
            this.CheckSerializedField(_cityAmbient, nameof(_cityAmbient));
            this.CheckSerializedField(_mapAmbient, nameof(_mapAmbient));
            this.CheckSerializedField(_marketAmbient, nameof(_marketAmbient));

            _audioSource = GetComponent<AudioSource>();
        }

        private void Start()
        {
            _audioSource = GetComponent<AudioSource>();
            _screenNavigator.OnScreenChanged += OnScreenChange;
        }

        private void OnScreenChange(ActiveScreen activeScreen)
        {
            switch (activeScreen)
            {
                case ActiveScreen.CITY:
                    _audioSource.clip = _cityAmbient;
                    break;
                case ActiveScreen.MAP:
                    _audioSource.clip = _mapAmbient;
                    break;
                case ActiveScreen.MARKET:
                    _audioSource.clip = _marketAmbient;
                    break;

            }
            _audioSource.Play();
        }
    }
}