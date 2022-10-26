namespace TradeCity.Engine.Core.Interfaces
{
    public interface ISessionService
    {
        Session.Session CurrentSession { get; set; }
    }
}