using System;
using TradeCity.Engine.Resources;
using TradeCity.Engine.Session;
using TradeCity.Engine.Utilities;

namespace TradeCity.Engine.Missions
{
    [Serializable]
    public class CollectResourceGoal : ResourceGoalBase
    {
        private readonly int _goal;
        private int _collected;

        public CollectResourceGoal(Resource resource, Player player = null) : base(resource, player)
        {
            _goal = resource.GetStock();
        }

        public override float CheckStatus()
        {
            return Math.Clamp(_collected / _goal, 0, 1);
        }

        public override void OnResourceChange(Resource resource)
        {
            if (resource.GetType() != _watched.GetType() || resource.GetStock() <= 0) return;
            _collected += resource.GetStock();
            IsAchieved();
        }

        protected override string GetText()
        {
            return $"Collect {_goal} {_watched.GetName()}!";
        }
    }
}