/**
* @(#) FrozenPlayerStrategy.cs
*/

namespace Lebeg134.Module.Session
{
    public partial class Player
    {
        public class FrozenPlayerStrategy : PlayerStrategyBase
        {
            public FrozenPlayerStrategy(Player subject) : base(subject) { }
            override public void Freeze()
            {
                // Do nothing, already frozen
            }
            override public void GoBankrupt()
            {
                // Frozen player can't go bankrupt
            }
            override public bool IsFrozen()
            {
                return true;
            }
            override public void Tick()
            {
                // Do nothing, player is frozen
            }
            override public void UnFreeze(IPlayerStrategy newStrategy)
            {
                player.playerStrategy = newStrategy;
            }
        }
    }
}
