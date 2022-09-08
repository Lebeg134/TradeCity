using TradeCity.Engine.Session;
using UnityEngine;

namespace TradeCity.Unity.Scripts.GUI.ResourceDisplays
{
    public class CostResourceDisplay : ResourceDisplay
    {
        [SerializeField] private bool _redIfNotEnough = true;
        protected override void Update()
        {
            base.Update();
            if (Watched != null && _redIfNotEnough)
            {
                _icon.color = Player.CurrentPlayer.CheckResource(Watched) ?
                Color.white : Color.red;
            }
        }
    }
}
