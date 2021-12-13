

using JHP4SD.Lebeg134.Module.Structures;
using JHP4SD.Lebeg134.Module.TimeManager;
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

            public virtual void tick()
            {
                foreach (ITickable tickable in player.owned)
                {
                    tickable.tick();
                }
            }

            public virtual void unFreeze(IPlayerStrategy newStrategy)
            {
                // Player not frozen, do nothing
            }
        }
    }
}
