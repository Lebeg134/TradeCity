using JHP4SD.Lebeg134.Module.Resources;
using JHP4SD.Lebeg134.Module.Structures;
using JHP4SD.Lebeg134.Units;
using Lebeg134.Resources.Common;
using Lebeg134.Resources.ConstructionIndustry;
using Lebeg134.Resources.EnergySector;
using Lebeg134.Resources.OilIndustry;
using Lebeg134.Resources.Workforce;
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
        public override List<IOwnable> Criteria()
        {
            return new List<IOwnable> { new ChemicalResearchFacility(), new ChemicalSafetyBureau() };
        }

        public override Branches getBranch()
        {
            return Branches.OIL;
        }

        public override int getMaxLevel()
        {
            return 10;
        }

        public override string getName()
        {
            return "Oil Distillery";
        }

        public override List<Resource> getProduce()
        {
            return new List<Resource> { new Fuel(2*level*level), new Chemicals(4*level*level) };
        }

        public override List<Resource> getUpkeep()
        {
            return new List<Resource> { new Oil(30 * level * level), new Electricity(26 * level * level) };
        }

        public override List<Resource> upgradeLevelsCosts(int level)
        {
            if (level == 0)
                return new List<Resource> { new Concrete(500), new Workforce(100) };
            else
                return new List<Resource> { new Concrete(500 + 100 * level * level), new Steel(100 * level * level) };
        }
    }

}
