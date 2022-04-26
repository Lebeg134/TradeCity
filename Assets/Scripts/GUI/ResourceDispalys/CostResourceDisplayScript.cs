using Lebeg134.Module.Session;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;
using UnityEngine.UI;

namespace Lebeg134.Scripts.GUI.ResourceDispalys
{
    internal class CostResourceDisplayScript:ResourceDisplayScript
    {
        protected override void Update()
        {
            base.Update();
            if (watched != null)
            {
                icon.color = Player.CurrentPlayer.checkResource(watched) ?
                Color.white : Color.red;
            }
            
        }
    }
}
