using Lebeg134.Module.Resources;
using Lebeg134.Module.Session;

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