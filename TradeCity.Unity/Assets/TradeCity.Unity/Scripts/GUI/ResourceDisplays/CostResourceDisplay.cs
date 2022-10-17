using TradeCity.Engine.Session;
using UnityEngine;

namespace TradeCity.Unity.Scripts.GUI.ResourceDisplays
{
    public class CostResourceDisplay : ResourceDisplay
    {
        [SerializeField] private const bool RedIfNotEnough = true;

        protected override void Update()
        {
            base.Update();
            if (Watched != null && RedIfNotEnough)
            {
                _icon.color = Player.CurrentPlayer.CheckResource(Watched) ?
                Color.white : Color.red;
            }
        }
    }
}
