using System;
using TradeCity.Engine.Session;
using TradeCity.Engine.Structures.Interfaces;

namespace TradeCity.Engine.Missions
{
    [Serializable]
    public class OwnableReward : IRewardable
    {
        private readonly IOwnable ownable;
        public OwnableReward(IOwnable ownable)
        {
            this.ownable = ownable;
        }
        public object GetReward()
        {
            return ownable;
        }

        public void Reward(Player player)
        {
            player.GiveStructure(ownable);
        }
    }
}