using Lebeg134.Module.Resources;
using Lebeg134.Module.Structures;
using Lebeg134.Resources.Common;
using Lebeg134.Resources.ConstructionIndustry;
using Lebeg134.Resources.EnergySector;
using Lebeg134.Resources.OilIndustry;
using Lebeg134.Resources.Workforce;
using Lebeg134.Units;
using System;
using System.Collections.Generic;
/**
* @(#) OilDistillery.cs
*/
namespace Lebeg134.Structures.OilIndustry
{
    [Serializable]
    public class OilDistillery : CommonProdBuilding
    {
        public override List<IOwnable> GetCriteria()
        {
            return new List<IOwnable> { new ChemicalResearchFacility(), new ChemicalSafetyBureau() };
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
            return "Oil Distillery";
        }

        public override List<Resource> GetProduce()
        {
            return new List<Resource> { new Fuel(2 * level * level), new Chemicals(4 * level * level) };
        }

        public override List<Resource> GetUpkeep()
        {
            return new List<Resource> { new Oil(30 * level * level), new Electricity(26 * level * level) };
        }

        public override List<Resource> GetUpgradeCost(int level)
        {
            if (level == 0)
                return new List<Resource> { new Concrete(500), new Workforce(100) };
            else
                return new List<Resource> { new Concrete(500 + 100 * level * level), new Steel(100 * level * level) };
        }
    }

}
