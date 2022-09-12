using System;
using TradeCity.Engine.Resources;
using TradeCity.Engine.Session;

namespace TradeCity.Engine.Missions
{
    [Serializable]
    public class ReachResourceGoal : ResourceGoalBase
    {
        private readonly int _goal;

        public ReachResourceGoal(Resource resource, Player player = null) : base(resource, player)
        {
            _goal = resource.GetStock();
        }

        public override float CheckStatus()
        {
            return Math.Clamp((float)_player.GetResCount(_watched) / _goal, 0, 1);
        }

        public override void OnResourceChange(Resource resource)
        {
            IsAchieved();
        }


        protected override string GetText()
        {
            return $"Reach {_goal} {_watched.GetName()}!";
        }
    }
}