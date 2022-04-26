using Lebeg134.Module.Session;

namespace Lebeg134.Scripts.GUI.ResourceDispalys
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
