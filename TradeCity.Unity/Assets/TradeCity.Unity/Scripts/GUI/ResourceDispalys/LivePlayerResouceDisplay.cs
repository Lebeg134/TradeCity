using TradeCity.Engine.Session;

namespace TradeCity.Unity.Scripts.GUI.ResourceDispalys
{
    public class LivePlayerResouceDisplay : LiveResourceDisplay
    {
        protected override void Start()
        {
            Watched = Player.CurrentPlayer.GetResRef(ConvertToRes(resource));
            base.Start();
        }
    }
}
