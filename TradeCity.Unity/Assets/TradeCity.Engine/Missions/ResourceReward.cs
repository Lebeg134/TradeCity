using Lebeg134.Module.Resources;
using Lebeg134.Module.Session;
using System;

namespace Lebeg134.Module.Missions
{
    [Serializable]
    public class ResourceReward : IRewardable
    {
        Resource resource;

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