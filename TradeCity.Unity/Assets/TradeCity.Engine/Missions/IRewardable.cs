using TradeCity.Engine.Session;

namespace TradeCity.Engine.Missions
{
    public interface IRewardable
    {
        void Reward(Player player);
        object GetReward();
    }
}