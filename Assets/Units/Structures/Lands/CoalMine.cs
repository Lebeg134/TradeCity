using Lebeg134.Module.Resources;
using Lebeg134.Module.Structures;
using Lebeg134.Resources.Common;
using Lebeg134.Resources.EnergySector;
using System;
using System.Collections.Generic;
/**
* @(#) CoalMine.cs
*/
namespace Lebeg134.Structures.Lands
{
    [Serializable]
    public class CoalMine : Land
    {
        public override string GetName()
        {
            return "Coal Mine";
        }
        public override string GetResourcepath()
        {
            return GetBasePath() + "CoalMine";
        }

        public override Land GetNew()
        {
            return new CoalMine();
        }

        protected override List<Resource> GetProduce(int level)
        {
            return new List<Resource> { new Coal(25) };
        }

        protected override List<Resource> GetCost(int level)
        {
            return new List<Resource> { new Money(100 * level + 250) };
        }
    }

}
