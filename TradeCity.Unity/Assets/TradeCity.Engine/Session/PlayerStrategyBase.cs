using System;
using TradeCity.Engine.TimeManager;

namespace TradeCity.Engine.Session
{
    public partial class Player
    {
        [Serializable]
        public abstract class PlayerStrategyBase : IPlayerStrategy
        {
            protected Player _player;

            protected PlayerStrategyBase(Player subject)
            {
                _player = subject;
            }

            public virtual void Freeze()
            {
                if (!_player.IsFrozen())
                    _player._playerStrategy = new FrozenPlayerStrategy(_player);
            }

            public virtual void GoBankrupt()
            {
                _player._playerStrategy = new BankruptPlayerStrategy(_player);
            }

            public virtual bool IsFrozen()
            {
                return false;
            }

            public virtual void Tick()
            {
                foreach (var tickable in _player._owned)
                    if (tickable is ITickable tickable1)
                        tickable1.Tick();
            }

            public virtual void UnFreeze(IPlayerStrategy newStrategy)
            {
                // Player not frozen, do nothing
            }
        }
    }
}