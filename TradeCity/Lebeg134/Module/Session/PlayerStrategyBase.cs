/**
 * @(#) PlayerStrategyBase.cs
 */

namespace JHP4SD.Lebeg134.Module.Session
{
    public partial class Player
    {
        public abstract class PlayerStrategyBase : IPlayerStrategy
        {
            protected Player player;
            public PlayerStrategyBase(Player subject)
            {
                player = subject;
            }
            public virtual void freeze()
            {
                player.playerStrategy = new FrozenPlayerStrategy(player);
            }
            public virtual void goBankrupt()
            {
                throw new System.NotImplementedException();
            }
            public virtual bool isFrozen()
            {
                return false;
            }
            public virtual void tick()
            {
                // TODO Do resource calculations
            }
            public virtual void unFreeze(IPlayerStrategy newStrategy)
            {
                // Player not frozen, do nothing
            }
        }
    }
}
