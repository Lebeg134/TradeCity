/**
* @(#) FrozenPlayerStrategy.cs
*/
using static JHP4SD.Lebeg134.Module.Session.Player;

namespace JHP4SD.Lebeg134.Module.Session
{
    public partial class Player
    {
        public class FrozenPlayerStrategy : PlayerStrategyBase
        {
            public FrozenPlayerStrategy(Player subject) : base(subject) { }
            override public void freeze()
            {
                // Do nothing, already frozen
            }
            override public void goBankrupt()
            {
                // Frozen player can't go bankrupt
            }
            override public bool isFrozen()
            {
                return true;
            }
            public void tick()
            {
                // Do nothing, player is frozen
            }
            override public void unFreeze(IPlayerStrategy newStrategy)
            {
                player.playerStrategy = newStrategy;
            }
        }
    }
}
