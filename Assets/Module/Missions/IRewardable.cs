using Lebeg134.Module.Session;

namespace Lebeg134.Module.Missions
{
    public interface IRewardable
    {
        void Reward(Player player);
        object GetReward();
    }
}