

using JHP4SD.GumRuntimes;
using JHP4SD.Lebeg134.Module.Resources;
using JHP4SD.Lebeg134.Module.Structures;
using JHP4SD.Lebeg134.Units;
using Lebeg134.Resources.ConstructionIndustry;
using Lebeg134.Resources.EnergySector;
using Lebeg134.Resources.OilIndustry;
using Lebeg134.Resources.Workforce;
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
        public override List<IOwnable> Criteria()
        {
            return new List<IOwnable>();
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
            return "Chemical Research Facility";
        }

        public override SpriteRuntime GetSprite()
        {
            return spriteLibrarySmall.DefaultSprite;
        }

        public override List<Resource> getUpkeep()
        {
            return new List<Resource> { new Electricity(2 * level) , new Oil(10)};
        }

        public override List<Resource> upgradeLevelsCosts(int level)
        {
            if (level == 0)
                return new List<Resource> { new Concrete(100), new Workforce(25) };
            else
                return new List<Resource> { new Concrete(100 + 50 * level), new Glass(50 * level) };
        }
    }

}
