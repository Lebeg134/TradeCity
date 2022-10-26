namespace TradeCity.Engine.Core
{
    public interface ISessionService
    {
        Session.Session CurrentSession { get; }
    }
}