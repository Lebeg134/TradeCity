/**
* @(#) BankruptPlayerStrategy.cs
*/
using JHP4SD.Lebeg134.Module.Structures;

namespace JHP4SD.Lebeg134.Module.Session
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
                foreach (IOwnable ownable in player.ownedBuildings)
                {
                    ownable.acquire(null);
                }
                foreach (IOwnable ownable in player.ownedLands)
                {
                    ownable.acquire(null);
                }
            }
            public override void unFreeze(IPlayerStrategy newStrategy)
            {
                // Do nothing, cannot unfreeze Bankrupt player
            }
        }
    }
}
