using Lebeg134.Module.Session;
using Lebeg134.Module.Structures;

public class OwnableReward : IRewardable
{
    IOwnable ownable;
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