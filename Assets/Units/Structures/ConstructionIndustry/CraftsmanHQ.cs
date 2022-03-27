using JHP4SD.Lebeg134.Module.Resources;
using JHP4SD.Lebeg134.Module.Structures;
using JHP4SD.Lebeg134.Units;
using Lebeg134.Resources.Common;
using Lebeg134.Resources.ConstructionIndustry;
using Lebeg134.Resources.EnergySector;
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
        public override List<Resource> Cost()
        {
            return new List<Resource> { new Concrete(100), new Steel(100) };
        }

        public override List<IOwnable> Criteria()
        {
            return new List<IOwnable>();
        }

        public override Branches getBranch()
        {
            return Branches.CONSTRUCTION;
        }

        public override string getName()
        {
            return "Craftsman HQ";
        }

        public override List<Resource> getUpkeep()
        {
            return new List<Resource> { new Electricity(5) };
        }
    }

}
