using JHP4SD.Lebeg134.Module.Session;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assets.Scripts.GUI.ResourceDispalys
{
    class LivePlayerResouceDisplayScript: LiveResourceDisplayScript
    {
        protected override void Start()
        {
            watched = Player.CurrentPlayer.getResRef(ConvertToRes(resource));
            base.Start();
        }
    }
}
