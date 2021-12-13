/**
* @(#) BankruptPlayerStrategy.cs
*/
using JHP4SD.Lebeg134.Module.Resources;
using JHP4SD.Lebeg134.Module.Structures;
using System;
using System.Collections.Generic;

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
                foreach (IOwnable ownable in player.owned)
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
