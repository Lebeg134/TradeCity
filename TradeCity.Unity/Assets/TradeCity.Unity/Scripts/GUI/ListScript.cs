using System.Collections.Generic;
using UnityEngine;

namespace TradeCity.Unity.Scripts.GUI
{
    /// <summary>
    /// Generic List display code for Unity UI elements
    /// </summary>
    /// <typeparam name="T"> Type of the displayed items</typeparam>
    /// <typeparam name="Script"> Script that is present on the ListItem Gameobjects</typeparam>
    /// <typeparam name="Collection"> Type of collection that is to be handled</typeparam>
    public abstract class ListScript<T> : MonoBehaviour
    {
        public GameObject ListItem;
        public GameObject Content;

        /// <summary>
        /// Gets called when the script is instantiated
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
            foreach (T item in GetCollection())
            {
                GameObject newListItem = Instantiate(ListItem);
                ProcessListItem(item, newListItem);
                newListItem.transform.SetParent(Content.transform);
            }
        }

        /// <summary>
        /// Clears the Content panel
        /// </summary>
        protected void Clear()
        {
            foreach (Transform child in Content.transform)
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
        protected abstract void ProcessListItem(T item, GameObject newListItem);

        /// <summary>
        /// Defines the collection to be shown in the list
        /// </summary>
        /// <returns> Collection of T </returns>
        protected abstract ICollection<T> GetCollection();

        /// <summary>
        /// Gets called once every frame
        /// Does nothing by default
        /// </summary>
        protected virtual void Update() { }
    }
}
