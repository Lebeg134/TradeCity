using Lebeg134.Module.Resources;
using Lebeg134.Module.Structures;
using Lebeg134.Resources.Common;
using Lebeg134.Units.Resources.Common;
using System;
using System.Collections.Generic;
/**
* @(#) ClearwaterLake.cs
*/
namespace Lebeg134.Structures.Lands
{
    [Serializable]
    public class ClearwaterLake : Land
    {
        public override string GetName()
        {
            return "Lake";
        }
        public override string GetResourcepath()
        {
            return GetBasePath() + "Clearwaterlake";
        }

        public override Land GetNew()
        {
            return new ClearwaterLake();
        }

        protected override List<Resource> ProductionLevels(int level)
        {
            return new List<Resource>() { new Water(10) };
        }

        protected override List<Resource> UpgradeLevelsCosts(int level)
        {
            return new List<Resource>() { new Money(100 * level) };
        }
    }

}
