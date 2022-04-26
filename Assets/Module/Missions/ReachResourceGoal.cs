using Lebeg134.Module.Resources;
using Lebeg134.Module.Session;
using Lebeg134.Module.Utilities;

public class ReachResourceGoal : ResourceGoalBase
{
    private int goal;
    public ReachResourceGoal(Resource resource, Player player, int goal) : base(resource, player)
    {
        this.player = player;
        this.goal = goal;
    }
    public override float CheckStatus()
    {
        return LebegUtil.Clamp((float)player.GetRes(watched) / goal, 0, 1);
    }
    public override void OnResourceChange(Resource resource)
    {
        IsAchieved();
    }
}