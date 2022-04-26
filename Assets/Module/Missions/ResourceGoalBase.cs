using Lebeg134.Module.Resources;
using Lebeg134.Module.Session;
using System;

public abstract class ResourceGoalBase : IAchievable
{
    public event Action OnAchieve;
    protected Resource watched;
    protected Player player;
    private bool achieved = false;
    public ResourceGoalBase(Resource watched, Player player)
    {
        this.watched = watched;
        this.player = player;
        //TODO Register OnResourceChange
    }
    protected void InvokeOnAchieve()
    {
        OnAchieve.Invoke();
    }
    public abstract float CheckStatus();

    public virtual bool IsAchieved()
    {
        if (CheckStatus() >= 1)
        {
            achieved = true;
            OnAchieve.Invoke();
            return true;
        }
        return achieved;
    }
    public abstract void OnResourceChange(Resource resource);
}