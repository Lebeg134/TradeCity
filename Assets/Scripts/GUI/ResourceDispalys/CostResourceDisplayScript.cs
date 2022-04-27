using Lebeg134.Module.Session;
using UnityEngine;

namespace Lebeg134.Scripts.GUI.ResourceDispalys
{
    internal class CostResourceDisplayScript : ResourceDisplayScript
    {
        public bool redIfNotEnough = true;
        protected override void Update()
        {
            base.Update();
            if (Watched != null && redIfNotEnough)
            {
                icon.color = Player.CurrentPlayer.CheckResource(Watched) ?
                Color.white : Color.red;
            }

        }
    }
}
