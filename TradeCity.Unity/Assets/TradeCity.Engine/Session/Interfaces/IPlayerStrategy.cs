namespace TradeCity.Engine.Session.Interfaces
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