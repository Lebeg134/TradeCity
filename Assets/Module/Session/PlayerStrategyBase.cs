using Lebeg134.Module.Resources;
using Lebeg134.Module.TimeManager;
using System;
using UnityEngine;
/**
* @(#) PlayerStrategyBase.cs
*/
namespace Lebeg134.Module.Session
{

    public partial class Player
    {
        [Serializable]
        public abstract class PlayerStrategyBase : IPlayerStrategy
        {
            protected Player player;
            public PlayerStrategyBase(Player subject)
            {
                player = subject;
            }
            public virtual void Freeze()
            {
                if (!player.IsFrozen())
                    player.playerStrategy = new FrozenPlayerStrategy(player);
            }
            public virtual void GoBankrupt()
            {
                player.playerStrategy = new BankruptPlayerStrategy(player);
            }
            public virtual bool IsFrozen()
            {
                return false;
            }

            public virtual void Tick()
            {
                foreach (var tickable in player.owned)
                {
                    if (tickable is ITickable)
                        ((ITickable)tickable).Tick();
                }
            }

            public virtual void UnFreeze(IPlayerStrategy newStrategy)
            {
                // Player not frozen, do nothing
            }
        }
    }
}
