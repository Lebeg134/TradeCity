namespace TradeCity.Engine.TimeManager
{
    public interface ITickable
    {
        void Tick();
        void Register();
    }
}