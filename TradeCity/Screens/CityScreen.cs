using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

using FlatRedBall;
using FlatRedBall.Input;
using FlatRedBall.Instructions;
using FlatRedBall.AI.Pathfinding;
using FlatRedBall.Graphics.Animation;
using FlatRedBall.Graphics.Particle;
using FlatRedBall.Math.Geometry;
using FlatRedBall.Localization;
using Lebeg134.Structures.Common;
using JHP4SD.Lebeg134.Module.Structures;

namespace JHP4SD.Screens
{
    public partial class CityScreen
    {

        void CustomInitialize()
        {
            Building.spriteLibrarySmall = new GumRuntimes.LebegForms.Resources.BuildingImagesSmallRuntime();
            Forms.BuildingTabs.RegisterAllBuildings();

        }

        void CustomActivity(bool firstTimeCalled)
        {


        }

        void CustomDestroy()
        {


        }

        static void CustomLoadStaticContent(string contentManagerName)
        {


        }

    }
}
