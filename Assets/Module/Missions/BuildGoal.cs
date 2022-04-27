using System;

public class BuildGoal : IAchievable
{
    public event Action OnAchieve;

    public float CheckStatus()
    {
        throw new NotImplementedException();
    }

    public bool IsAchieved()
    {
        throw new NotImplementedException();
    }
}