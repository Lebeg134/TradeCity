using Lebeg134.Module.Resources;
using Lebeg134.Module.Structures;
using Lebeg134.Resources.ConstructionIndustry;
using Lebeg134.Resources.EnergySector;
using Lebeg134.Resources.OilIndustry;
using Lebeg134.Resources.Workforce;
using Lebeg134.Units;
using System;
using System.Collections.Generic;
/**
* @(#) ChemicalResearchFacility.cs
*/
namespace Lebeg134.Structures.OilIndustry
{
    [Serializable]
    public class ChemicalResearchFacility : CommonBuilding
    {
        public override List<IOwnable> GetCriteria()
        {
            return new List<IOwnable>();
        }

        public override Branches GetBranch()
        {
            return Branches.OIL;
        }

        public override int REPLACEMEGetMaxLevel()
        {
            return 10;
        }

        public override string GetName()
        {
            return "Chemical Research Facility";
        }

        public override List<Resource> GetUpkeep()
        {
            return new List<Resource> { new Electricity(2 * level), new Oil(10) };
        }

        public override List<Resource> GetUpgradeCost(int level)
        {
            if (level == 0)
                return new List<Resource> { new Concrete(100), new Workforce(25) };
            else
                return new List<Resource> { new Concrete(100 + 50 * level), new Glass(50 * level) };
        }
    }

}
