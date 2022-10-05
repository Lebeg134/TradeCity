namespace TradeCity.Engine.TimeManager
{
    public interface IClock
    {
        bool IsEnabled { get; }

        void Start();

        void Pause();

        void Toggle();

        void SetSpeed(Speed speed);

        void Register(ITickable tickable);

        void Remove(ITickable tickable);

        void Clear();
    }
}