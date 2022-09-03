using System;
using TradeCity.Engine.Session;

namespace TradeCity.Engine.Missions
{
    [Serializable]
    public class BuildGoal : IAchievable
    {
        public string Text => throw new NotImplementedException();

        public event Action OnAchieve;

        public void Accept(Player by)
        {
            throw new NotImplementedException();
        }

        public float CheckStatus()
        {
            throw new NotImplementedException();
        }

        public bool IsAchieved()
        {
            throw new NotImplementedException();
        }

        public void RegisterToEvents()
        {
            throw new NotImplementedException();
        }
    }
}