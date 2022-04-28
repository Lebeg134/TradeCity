using Lebeg134.Module.Session;
using System;

namespace Lebeg134.Module.Missions
{
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