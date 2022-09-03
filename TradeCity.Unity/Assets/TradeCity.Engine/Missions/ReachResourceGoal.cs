using System;
using TradeCity.Engine.Resources;
using TradeCity.Engine.Session;
using TradeCity.Engine.Utilities;

namespace TradeCity.Engine.Missions
{
    [Serializable]
    public class ReachResourceGoal : ResourceGoalBase
    {
        private readonly int goal;
        public ReachResourceGoal(Resource resource, Player player = null) : base(resource, player)
        {
            goal = resource.GetStock();
        }
        public override float CheckStatus()
        {
            return LebegUtil.Clamp((float)player.GetRes(watched) / goal, 0, 1);
        }
        public override void OnResourceChange(Resource resource)
        {
            IsAchieved();
        }

        protected override string GetText()
        {
            return string.Format("Reach {0} {1}!", goal, watched.GetName());
        }
    }
}