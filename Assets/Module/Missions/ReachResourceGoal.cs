using Lebeg134.Module.Resources;
using Lebeg134.Module.Session;
using Lebeg134.Module.Utilities;
using System;

namespace Lebeg134.Module.Missions
{
    [Serializable]
    public class ReachResourceGoal : ResourceGoalBase
    {
        private int goal;
        public ReachResourceGoal(Resource resource, Player player = null) : base(resource, player)
        {
            goal = resource.Amount();
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