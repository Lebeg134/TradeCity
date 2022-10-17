using System;
using System.Collections.Generic;
using TradeCity.Engine.Production;
using TradeCity.Engine.Resources;
using TradeCity.Engine.Structures;
using TradeCity.Engine.Structures.Interfaces;
using TradeCity.Units.Resources.Common;
using TradeCity.Units.Resources.ConstructionIndustry;
using TradeCity.Units.Resources.EnergySector;
using TradeCity.Units.Resources.OilIndustry;
using TradeCity.Units.Resources.Workforce;

namespace TradeCity.Units.Structures.OilIndustry
{
    [Serializable]
    public class OilDistillery : Building
    {
        public OilDistillery()
        {
            Recipes.Add(new ManyToOneRecipe(new List<Resource> { new Electricity(15), new Oil(15) }, new Fuel(2), 1));
            Recipes.Add(new ManyToOneRecipe(new List<Resource> { new Electricity(10), new Oil(15) }, new Chemicals(4),
                1));
        }

        public override void Upgrade()
        {
            base.Upgrade();
            foreach (var recipe in Recipes) recipe.Limit = _level * _level;
        }

        public override List<IOwnable> GetCriteria()
        {
            return new List<IOwnable> { new ChemicalResearchFacility(), new ChemicalSafetyBureau() };
        }

        public override Branches GetBranch()
        {
            return Branches.Oil;
        }

        protected override int GetMaxLevel()
        {
            return 10;
        }

        public override string GetName()
        {
            return "Oil Distillery";
        }

        public override List<Resource> GetProduce()
        {
            return new List<Resource> { new Fuel(2 * _level * _level), new Chemicals(4 * _level * _level) };
        }

        protected override List<Resource> GetUpkeep(int level)
        {
            return new List<Resource> { new Oil(30 * level * level), new Electricity(26 * level * level) };
        }

        protected override List<Resource> GetCost(int level)
        {
            if (level == 0)
                return new List<Resource> { new Concrete(500), new Workforce(100) };
            return new List<Resource> { new Concrete(500 + 100 * level * level), new Steel(100 * level * level) };
        }
    }
}