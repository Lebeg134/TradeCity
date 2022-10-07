using System;
using AutSoft.UnitySupplements.EventBus;
using Injecter;
using TradeCity.Engine.Core;
using TradeCity.Engine.Resources;
using TradeCity.Engine.Session;

namespace TradeCity.Engine.Missions
{
    [Serializable]
    public abstract class ResourceGoalBase : IAchievable
    {
        [Inject] protected readonly IEventBus _eventBus;

        private bool _achieved;
        protected Player _player;
        protected Resource _watched;

        protected ResourceGoalBase(Resource watched, Player player = null)
        {
            _eventBus = EngineCore.Instance.InjectEventBus();
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
            _eventBus.Subscribe<Player.ResourceChanged>(HandleResourceEvent);
            //TODO unsubscribe!!
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

        protected virtual void HandleResourceEvent(Player.ResourceChanged message)
        {
            if (_player != message.OwnerPlayer) return;
            OnResourceChange(message.ChangedResource);
        }

        public abstract void OnResourceChange(Resource resource);
    }
}