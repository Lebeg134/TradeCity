using TradeCity.Engine.Session;

namespace TradeCity.Unity.Scripts.GUI.ResourceDisplays
{
    public class LivePlayerResourceDisplay : LiveResourceDisplay
    {
        protected override void Start()
        {
            if (Resource != null)
                Watched = Player.CurrentPlayer.GetRes(ConvertToRes(Resource));
            UpdateVisuals();

        }
    }
}
