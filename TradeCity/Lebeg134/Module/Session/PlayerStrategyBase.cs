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
                if(!player.isFrozen())
                    player.playerStrategy = new FrozenPlayerStrategy(player);
            }
            public virtual void goBankrupt()
            {
                player.playerStrategy = new BankruptPlayerStrategy(player);
            }
            public virtual bool isFrozen()
            {
                return false;
            }

            public void tick()
            {
                throw new System.NotImplementedException();
            }

            public virtual void unFreeze(IPlayerStrategy newStrategy)
            {
                // Player not frozen, do nothing
            }
        }
    }
}
