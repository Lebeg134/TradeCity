using System;
using TradeCity.Engine.Session;

namespace TradeCity.Engine.Missions
{
    public interface IAchievable
    {
        string Text { get; }

        event Action OnAchieve;

        float CheckStatus();
        bool IsAchieved();
        void RegisterToEvents();
        void Accept(Player by);
    }
}