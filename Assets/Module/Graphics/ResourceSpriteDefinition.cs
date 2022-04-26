using Lebeg134.Module.Resources;
using Lebeg134.Units.Resources.Common;
using Lebeg134.Resources.Workforce;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lebeg134.Assets.Module.Graphics
{
    public static class ResourceSpriteDefinition
    {
        static Dictionary<Resource, string> definitions = new Dictionary<Resource, string>
        {
            { new Money(0), "Assets/Sprites/Resources/ResourceIcons/money-stack.png" },
            { new Workforce(0), "Assets/Sprites/Resources/ResourceIcons/money-stack.png" },
        };
    }
}
