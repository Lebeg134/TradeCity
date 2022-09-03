using System;
using TradeCity.Engine.Resources;
using TradeCity.Engine.Session;

namespace TradeCity.Engine.Missions
{
    [Serializable]
    public class ResourceReward : IRewardable
    {
        private readonly Resource resource;

        public ResourceReward(Resource resource)
        {
            this.resource = resource;
        }
        public object GetReward()
        {
            return resource;
        }

        public void Reward(Player player)
        {
            player.GiveRes(resource);
        }
    }
}