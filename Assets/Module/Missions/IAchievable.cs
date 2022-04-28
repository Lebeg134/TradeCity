using Lebeg134.Module.Session;
using System;

public interface IAchievable
{
    string Text { get; }

    event Action OnAchieve;

    float CheckStatus();
    bool IsAchieved();
    void RegisterToEvents();
    void Accept(Player by);
}