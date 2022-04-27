using Lebeg134.Module.Resources;
using Lebeg134.Module.Session;
using Lebeg134.Module.Utilities;

public class CollectResourceGoal : ResourceGoalBase
{
    int goal;
    int collected = 0;
    public CollectResourceGoal(Resource resource, Player player, int goal) : base(resource, player)
    {
        this.goal = goal;
    }
    public override float CheckStatus()
    {
        return LebegUtil.Clamp((float)collected / goal, 0, 1);
    }
    public override void OnResourceChange(Resource resource)
    {
        if (resource.GetType() == watched.GetType() && resource.Amount() > 0)
        {
            collected += resource.Amount();
            IsAchieved();
        }
    }
}