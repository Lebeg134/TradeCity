using Lebeg134.Module.Session;

public interface IRewardable
{
    void Reward(Player player);
    object GetReward();
}