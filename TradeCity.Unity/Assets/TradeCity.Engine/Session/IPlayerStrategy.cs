namespace TradeCity.Engine.Session
{
    public interface IPlayerStrategy
    {
        void Freeze();
        void UnFreeze(IPlayerStrategy newStrategy);
        bool IsFrozen();
        void GoBankrupt();
        void Tick();
    }
}