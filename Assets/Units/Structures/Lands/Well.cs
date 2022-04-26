using Lebeg134.Module.Resources;
using Lebeg134.Module.Structures;
using Lebeg134.Units.Resources.Common;
using Lebeg134.Resources.Common;
using System;
using System.Collections.Generic;
/**
* @(#) Well.cs
*/
namespace Lebeg134.Structures.Lands
{
    [Serializable]
    public class Well : Land
    {
        public override string getName()
        {
            return "Pumping Station";
        }
        public override string GetResourcepath()
        {
            return getBasePath() + "Well";
        }
        public override Land GetNew()
        {
            return new Well();
        }

        protected override List<Resource> productionLevels(int level)
        {
            return new List<Resource>() { new Water(10) };
        }

        protected override List<Resource> upgradeLevelsCosts(int level)
        {
            return new List<Resource>() { new Money(100 * level) };
        }
    }

}
