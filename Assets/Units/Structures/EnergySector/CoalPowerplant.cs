using Lebeg134.Module.Production;
using Lebeg134.Module.Resources;
using Lebeg134.Module.Structures;
using Lebeg134.Resources.Common;
using Lebeg134.Resources.ConstructionIndustry;
using Lebeg134.Resources.EnergySector;
using Lebeg134.Resources.Workforce;
using Lebeg134.Units;
using System;
using System.Collections.Generic;
using UnityEngine;
/**
* @(#) CoalPowerplant.cs
*/
namespace Lebeg134.Structures.EnergySector
{
    [Serializable]
    public class CoalPowerplant : Building
    {
        public CoalPowerplant()
        {
            recipes.Add(new SimpleRecipe(new Coal(3), new Electricity(1), 5));
            Debug.Log("Recipe added");
        }
        public override void Upgrade()
        {
            base.Upgrade();
            recipes[0].Limit += 5;
        }
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

        protected override List<Resource> GetUpkeep(int level)
        {
            return new List<Resource>();
        }

        public override List<IOwnable> GetCriteria()
        {
            return new List<IOwnable>();
        }

        protected override List<Resource> GetCost(int level)
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

        protected override int GetMaxLevel()
        {
            return 100;
        }
    }
}
