using Lebeg134.Module.Resources;
using Lebeg134.Module.Session;
using Lebeg134.Module.Utilities;
using System;

namespace Lebeg134.Module.Missions
{
    [Serializable]
    public class CollectResourceGoal : ResourceGoalBase
    {
        int goal;
        int collected = 0;
        public CollectResourceGoal(Resource resource, Player player = null) : base(resource, player)
        {
            goal = resource.GetStock();
        }
        public override float CheckStatus()
        {
            return LebegUtil.Clamp((float)collected / goal, 0, 1);
        }
        public override void OnResourceChange(Resource resource)
        {
            if (resource.GetType() == watched.GetType() && resource.GetStock() > 0)
            {
                collected += resource.GetStock();
                IsAchieved();
            }
        }
        protected override string GetText()
        {
            return string.Format("Collect {0} {1}!", goal, watched.GetName());
        }
    }
}