/**
* @(#) BankruptPlayerStrategy.cs
*/

using TradeCity.Engine.Structures.Interfaces;

namespace TradeCity.Engine.Session
{
    public partial class Player
    {
        public class BankruptPlayerStrategy : FrozenPlayerStrategy
        {
            public BankruptPlayerStrategy(Player player) : base(player)
            {
                DeleteOwnerships();
            }
            private void DeleteOwnerships()
            {
                foreach (IOwnable ownable in player.owned)
                {
                    ownable.Acquire(null);
                }
            }
            public override void UnFreeze(IPlayerStrategy newStrategy)
            {
                // Do nothing, cannot unfreeze Bankrupt player
            }
        }
    }
}
