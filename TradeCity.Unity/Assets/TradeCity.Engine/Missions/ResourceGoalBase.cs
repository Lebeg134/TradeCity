using System;
using TradeCity.Engine.Resources;
using TradeCity.Engine.Session;

namespace TradeCity.Engine.Missions
{
    [Serializable]
    public abstract class ResourceGoalBase : IAchievable
    {
        private bool _achieved;
        protected Player _player;
        protected Resource _watched;

        protected ResourceGoalBase(Resource watched, Player player = null)
        {
            _watched = watched;
            if (player != null)
                Accept(player);
        }

        public event Action OnAchieve;

        public string Text => GetText();

        public abstract float CheckStatus();

        public virtual bool IsAchieved()
        {
            if (_achieved) return true;
            if (!(CheckStatus() >= 1)) return _achieved;

            _achieved = true;
            OnAchieve?.Invoke();
            return true;
        }

        public void RegisterToEvents()
        {
            _player.OnResourceChange += OnResourceChange;
        }

        public void Accept(Player by)
        {
            _player = by;
            RegisterToEvents();
        }

        protected abstract string GetText();

        protected void InvokeOnAchieve()
        {
            OnAchieve?.Invoke();
        }

        public abstract void OnResourceChange(Resource resource);
    }
}