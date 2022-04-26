using Lebeg134.Module.Session;
using Lebeg134.Module.TimeManager;
using System;

public class Mission : ITickable
{
    private Player owner;
    private IAchievable goal;
    private IRewardable reward;
    private bool isClaimed;
    private bool isAchieved;

    public event Action OnAchievement;
    public event Action OnClaim;

    public Mission(IAchievable goal, IRewardable reward, Player owner = null)
    {
        this.goal = goal;
        this.reward = reward;
        this.owner = owner;
        goal.OnAchieve += Check;
    }

    public float CheckStatus()
    {
        return goal.CheckStatus();
    }

    public void Claim()
    {
        if (isAchieved)
        {
            reward.Reward(owner);
            OnClaim.Invoke();
        }
        else
            throw new MissionNotAchievedException();
    }

    public void Register()
    {
        Clock.Instance.Register(this);
    }

    public void Check()
    {
        if (!isAchieved && goal.IsAchieved())
        {
            isAchieved = true;
            OnAchievement.Invoke();
        }
    }

    public void Tick()
    {
        Check();
    }

    public bool IsAchieved()
    {
        return isAchieved;
    }

    public bool IsClaimed()
    {
        return isClaimed;
    }
}