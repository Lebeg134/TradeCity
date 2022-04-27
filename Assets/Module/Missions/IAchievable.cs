using System;

public interface IAchievable
{
    event Action OnAchieve;

    float CheckStatus();
    bool IsAchieved();
}