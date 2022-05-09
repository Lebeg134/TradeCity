using Lebeg134.Module.Resources;
using Lebeg134.Module.Structures;
using Lebeg134.Resources.Common;
using Lebeg134.Resources.ConstructionIndustry;
using Lebeg134.Resources.EnergySector;
using Lebeg134.Units;
using System;
using System.Collections.Generic;
/**
* @(#) CraftsmanHQ.cs
*/
namespace Lebeg134.Structures.ConstructionIndustry
{
    [Serializable]
    public class CraftsmanHQ : SpecialBuilding
    {
        protected override List<Resource> GetCost()
        {
            return new List<Resource> { new Concrete(100), new Steel(100) };
        }

        public override List<IOwnable> GetCriteria()
        {
            return new List<IOwnable>();
        }

        public override Branches GetBranch()
        {
            return Branches.CONSTRUCTION;
        }

        public override string GetName()
        {
            return "Craftsman HQ";
        }

        public override List<Resource> GetUpkeep()
        {
            return new List<Resource> { new Electricity(5) };
        }
    }

}
