using System;
using TradeCity.Engine.Resources;
using TradeCity.Engine.Session;

namespace TradeCity.Engine.Missions
{
    [Serializable]
    public abstract class ResourceGoalBase : IAchievable
    {
        public event Action OnAchieve;
        protected Resource _watched;
        protected Player _player;
        private bool _achieved;

        public string Text => GetText();

        protected abstract string GetText();

        protected ResourceGoalBase(Resource watched, Player player = null)
        {
            _watched = watched;
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
            if (_achieved) return true;
            if (!(CheckStatus() >= 1)) return _achieved;

            _achieved = true;
            OnAchieve?.Invoke();
            return true;
        }

        public abstract void OnResourceChange(Resource resource);

        public void RegisterToEvents()
        {
            _player.OnResourceChange += OnResourceChange;
        }

        public void Accept(Player by)
        {
            _player = by;
            RegisterToEvents();
        }
    }
}