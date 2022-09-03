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
            return LebegUtil.Clamp((float)_collected / _goal, 0, 1);
        }
        public override void OnResourceChange(Resource resource)
        {
            if (resource.GetType() == _watched.GetType() && resource.GetStock() > 0)
            {
                _collected += resource.GetStock();
                IsAchieved();
            }
        }
        protected override string GetText()
        {
            return string.Format("Collect {0} {1}!", _goal, _watched.GetName());
        }
    }
}