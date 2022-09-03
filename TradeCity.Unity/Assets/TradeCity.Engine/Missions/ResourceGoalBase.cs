using System;
using TradeCity.Engine.Resources;
using TradeCity.Engine.Session;

namespace TradeCity.Engine.Missions
{
    [Serializable]
    public abstract class ResourceGoalBase : IAchievable
    {
        public event Action OnAchieve;
        protected Resource watched;
        protected Player player;
        private bool achieved = false;

        public string Text => GetText();

        protected abstract string GetText();

        public ResourceGoalBase(Resource watched, Player player = null)
        {
            this.watched = watched;
            if (player != null)
                Accept(player);
        }
        protected void InvokeOnAchieve()
        {
            OnAchieve?.Invoke();
        }
        public abstract float CheckStatus();

        public virtual bool IsAchieved()
        {
            if (achieved) return true;
            if (CheckStatus() >= 1)
            {
                achieved = true;
                OnAchieve?.Invoke();
                return true;
            }
            return achieved;
        }
        public abstract void OnResourceChange(Resource resource);

        public void RegisterToEvents()
        {
            player.OnResourceChange += OnResourceChange;
        }

        public void Accept(Player by)
        {
            player = by;
            RegisterToEvents();
        }
    }
}