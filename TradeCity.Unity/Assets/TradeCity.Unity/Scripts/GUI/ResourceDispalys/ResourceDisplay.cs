using System.Collections.Generic;
using TradeCity.Engine.Resources;
using TradeCity.Engine.Session;
using UnityEngine;
using UnityEngine.UI;
using AutSoft.UnitySupplements.Vitamins;

namespace TradeCity.Unity.Scripts.GUI.ResourceDispalys
{
    public class ResourceDisplay : MonoBehaviour
    {
        [SerializeField] protected Text display;
        [SerializeField] protected Text resName;
        [SerializeField] protected Image icon;

        private readonly string[] options = GetOptions().ToArray();
        [Dropdown("options")]
        public string resource;

        private Resource _watched;
        public Resource Watched
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
            this.CheckSerializedField(display, nameof(display));
            this.CheckSerializedField(resName, nameof(resName));
            this.CheckSerializedField(icon, nameof(icon));
        }

        protected virtual void Start()
        {
            if (Watched == null)
                Watched = ConvertToRes(resource);
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
            if (Watched == null) return;
            resName.text = Watched.GetName();
            display.text = Watched.GetStock().ToString();
            LoadSprite();
        }

        protected void LoadSprite()
        {
            var loadedSprite = Resources.Load<Sprite>(Watched.GetResourcepath());
            if (loadedSprite != null)
                icon.sprite = loadedSprite;
        }

        public static List<string> GetOptions()
        {
            List<Resource> reslist = SessionGenerator.GetResourceList();
            List<string> strlist = new();
            foreach (Resource res in reslist)
            {
                strlist.Add(res.GetName());
            }
            return strlist;
        }

        public static Resource ConvertToRes(string name)
        {
            foreach (Resource res in SessionGenerator.GetResourceList())
            {
                if (res.GetName() == name)
                    return res;
            }
            return null;
        }
    }
}
