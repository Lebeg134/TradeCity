#nullable enable
using AutSoft.UnitySupplements.Vitamins;
using System.Collections.Generic;
using UnityEngine;

namespace TradeCity.Unity.Scripts.GUI
{
    /// <summary>
    /// Generic List display code for Unity UI elements
    /// </summary>
    /// <typeparam name="T"> Type of the displayed items</typeparam>
    /// <typeparam name="TListItem"> Script on List items</typeparam>
    public abstract class SimpleList<T, TListItem> : MonoBehaviour where TListItem : MonoBehaviour
    {
        [SerializeField] protected TListItem _listItem = default!;
        [SerializeField] protected GameObject _content = default!;

        protected virtual void Awake()
        {
            this.CheckSerializedField(_listItem, nameof(_listItem));
            this.CheckSerializedField(_content, nameof(_content));
        }

        /// <summary>
        /// Initial population of the list
        /// </summary>
        protected virtual void Start()
        {
            Fill();
        }

        /// <summary>
        /// Fills the Content panel with the items provided in GetCollection()
        /// List items get processed through ProcessListItem()
        /// </summary>
        protected void Fill()
        {
            foreach (var item in GetCollection())
            {
                var newListItem = Instantiate(_listItem, _content.transform);
                ProcessListItem(item, newListItem);
            }
        }

        /// <summary>
        /// Clears the Content panel
        /// </summary>
        protected void Clear()
        {
            foreach (Transform child in _content.transform)
            {
                Destroy(child.gameObject);
            }
        }

        /// <summary>
        /// Clears then refreshes the Content panel
        /// </summary>
        public void Refresh()
        {
            Clear();
            Fill();
        }

        /// <summary>
        /// Processes List items and sets it's display parameters
        /// </summary>
        /// <param name="item"> Item to be displayed</param>
        /// <param name="newListItem"> Displaying Gameobject that will be added to the list </param>
        protected abstract void ProcessListItem(T item, TListItem newListItem);

        /// <summary>
        /// Defines the collection to be shown in the list
        /// </summary>
        /// <returns> Collection of T </returns>
        protected abstract IEnumerable<T> GetCollection();

        /// <summary>
        /// Does nothing by default
        /// </summary>
        protected virtual void Update() { }
    }
}
