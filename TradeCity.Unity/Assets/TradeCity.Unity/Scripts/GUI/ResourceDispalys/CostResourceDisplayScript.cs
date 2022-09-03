using TradeCity.Engine.Session;
using UnityEngine;

namespace TradeCity.Unity.Scripts.GUI.ResourceDispalys
{
    internal class CostResourceDisplayScript : ResourceDisplayScript
    {
        public bool redIfNotEnough = true;
        protected override void Update()
        {
            base.Update();
            if (Watched != null && redIfNotEnough)
            {
                icon.color = Player.CurrentPlayer.CheckResource(Watched) ?
                Color.white : Color.red;
            }
        }
    }
}
