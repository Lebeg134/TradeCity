using Lebeg134.Module.Resources;
using Lebeg134.Module.Structures;
using Lebeg134.Resources.Common;
using Lebeg134.Resources.ConstructionIndustry;
using Lebeg134.Resources.EnergySector;
using Lebeg134.Resources.Workforce;
using Lebeg134.Units;
using System;
using System.Collections.Generic;
/**
* @(#) CoalPowerplant.cs
*/
namespace Lebeg134.Structures.EnergySector
{
    [Serializable]
    public class CoalPowerplant : CommonProdBuilding
    {
        public override Branches GetBranch()
        {
            return Branches.ENERGY;
        }

        public override string GetName()
        {
            return "Coal Powerplant";
        }
        public override string GetResourcepath()
        {
            return GetBasePath() + "coal_powerplant";
        }

        public override List<Resource> GetProduce()
        {
            return new List<Resource> { new Electricity(5 * level) };
        }

        public override List<Resource> GetUpkeep()
        {
            return new List<Resource> { new Coal(15 * level) };
        }

        public override List<IOwnable> Criteria()
        {
            return new List<IOwnable>();
        }

        public override List<Resource> UpgradeLevelsCosts(int level)
        {
            if (level == 0)
                return new List<Resource> { new Stone(100), new Workforce(50) };
            else if (level < 25)
                return new List<Resource> { new Bricks(50 * level), new Steel(25 * level) };
            else if (level < 75)
                return new List<Resource> { new Concrete(50 * level), new Steel(25 * level) };
            else
                return new List<Resource> { new ReinforcedConcrete(50 * level), new Steel(25 * level) };
        }

        public override int GetMaxLevel()
        {
            return 100;
        }
    }
}
