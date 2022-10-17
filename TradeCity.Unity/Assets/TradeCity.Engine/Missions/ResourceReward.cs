using System;
using TradeCity.Engine.Resources;
using TradeCity.Engine.Session;

namespace TradeCity.Engine.Missions
{
    [Serializable]
    public class ResourceReward : IRewardable
    {
        private readonly Resource _resource;

        public ResourceReward(Resource resource)
        {
            _resource = resource;
        }

        public object GetReward()
        {
            return _resource;
        }

        public void Reward(Player player)
        {
            player.GiveRes(_resource);
        }
    }
}