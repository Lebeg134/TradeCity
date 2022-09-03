using TradeCity.Engine.Session;

namespace TradeCity.Unity.Scripts.GUI.ResourceDispalys
{
    class LivePlayerResouceDisplayScript : LiveResourceDisplayScript
    {
        protected override void Start()
        {
            Watched = Player.CurrentPlayer.GetResRef(ConvertToRes(resource));
            base.Start();
        }
    }
}
