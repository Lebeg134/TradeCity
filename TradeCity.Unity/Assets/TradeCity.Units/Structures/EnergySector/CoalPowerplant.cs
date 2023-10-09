using System;
using System.Collections.Generic;
using TradeCity.Engine.Production;
using TradeCity.Engine.Resources;
using TradeCity.Engine.Structures;
using TradeCity.Engine.Structures.Interfaces;
using TradeCity.Units.Resources.Common;
using TradeCity.Units.Resources.ConstructionIndustry;
using TradeCity.Units.Resources.EnergySector;
using TradeCity.Units.Resources.Workforce;

namespace TradeCity.Units.Structures.EnergySector
{
    [Serializable]
    public class CoalPowerplant : Building
    {
        public CoalPowerplant()
        {
            _recipes.Add(new SimpleRecipe(new Coal(2), new Electricity(1), 10));
        }

        public override string GetName()
        {
            return "Coal Powerplant";
        }

        public override Branches GetBranch()
        {
            return Branches.Energy;
        }

        public override void Upgrade()
        {
            base.Upgrade();
            _recipes[0].Limit += 10;
        }


        public override string GetResourcePath()
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
            if (level < 25)
                return new List<Resource> { new Bricks(50 * level), new Steel(25 * level) };
            if (level < 75)
                return new List<Resource> { new Concrete(50 * level), new Steel(25 * level) };
            return new List<Resource> { new ReinforcedConcrete(50 * level), new Steel(25 * level) };
        }

        protected override int GetMaxLevel()
        {
            return 100;
        }
    }
}