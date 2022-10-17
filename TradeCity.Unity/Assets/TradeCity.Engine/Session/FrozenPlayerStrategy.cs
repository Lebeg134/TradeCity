namespace TradeCity.Engine.Session
{
    public partial class Player
    {
        public class FrozenPlayerStrategy : PlayerStrategyBase
        {
            public FrozenPlayerStrategy(Player subject) : base(subject)
            {
            }

            public override void Freeze()
            {
                // Do nothing, already frozen
            }

            public override void GoBankrupt()
            {
                // Frozen player can't go bankrupt
            }

            public override bool IsFrozen()
            {
                return true;
            }

            public override void Tick()
            {
                // Do nothing, player is frozen
            }

            public override void UnFreeze(IPlayerStrategy newStrategy)
            {
                _player._playerStrategy = newStrategy;
            }
        }
    }
}