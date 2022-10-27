#nullable enable
using AutSoft.UnitySupplements.Vitamins;
using TMPro;
using TradeCity.Engine.Resources;
using UnityEngine;
using UnityEngine.UI;

namespace TradeCity.Unity.Scripts.GUI.ResourceDisplays
{
    public class ResourceDisplay : MonoBehaviour
    {
        [SerializeField] protected TMP_Text _display = default!;
        [SerializeField] protected TMP_Text _resName = default!;
        [SerializeField] protected Image _icon = default!;

        private Resource? _watched;
        public Resource? Watched
        {
            get => _watched;
            set
            {
                _watched = value;
                OnWatchedChanged();
            }
        }

        protected virtual void Awake()
        {
            this.CheckSerializedField(_display, nameof(_display));
            this.CheckSerializedField(_resName, nameof(_resName));
            this.CheckSerializedField(_icon, nameof(_icon));
        }

        protected virtual void Start()
        {
            UpdateVisuals();
        }

        protected virtual void Update()
        {
            // Overwritten in children
        }

        protected virtual void OnWatchedChanged()
        {
            UpdateVisuals();
        }

        protected virtual void UpdateVisuals()
        {
            if (Watched == null)
            {
                _resName.text = "Null";
                _display.text = "999";
                return;
            }
            _resName.text = Watched.GetName();
            _display.text = Watched.GetStock().ToString();
            LoadSprite();
        }

        protected void LoadSprite()
        {
            Sprite loadedSprite = Resources.Load<Sprite>(Watched?.GetResourcePath());
            if (loadedSprite != null)
                _icon.sprite = loadedSprite;
        }
    }
}
