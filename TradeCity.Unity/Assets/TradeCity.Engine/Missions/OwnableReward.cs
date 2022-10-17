using System;
using TradeCity.Engine.Session;
using TradeCity.Engine.Structures.Interfaces;

namespace TradeCity.Engine.Missions
{
    [Serializable]
    public class OwnableReward : IRewardable
    {
        private readonly IOwnable _ownable;

        public OwnableReward(IOwnable ownable)
        {
            _ownable = ownable;
        }

        public object GetReward()
        {
            return _ownable;
        }

        public void Reward(Player player)
        {
            player.GiveStructure(_ownable);
        }
    }
}