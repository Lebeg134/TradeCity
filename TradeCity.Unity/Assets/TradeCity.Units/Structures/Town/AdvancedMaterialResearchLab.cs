/**
 * @(#) AdvancedMaterialResearchLab.cs
 */

using System.Collections.Generic;
using TradeCity.Engine.Resources;
using TradeCity.Engine.Structures.EasyInheritance;
using TradeCity.Engine.Structures.Interfaces;
using TradeCity.Units.Resources.Common;
using TradeCity.Units.Resources.Workforce;

namespace TradeCity.Units.Structures.ConstructionIndustry
{
    public class AdvancedMaterialResearchLab :SpecialBuilding
    {
        public override string GetName()
        {
            return "Advanced Material Research";
        }

        public override Branches GetBranch()
        {
            return Branches.Town;
        }

        public override List<IOwnable> GetCriteria()
        {
            return new List<IOwnable>();
        }

        public override List<Resource> GetUpkeep()
        {
            return new List<Resource>();
        }


        protected override int GetMaxLevel()
        {
            return 10;
        }

        public override List<Resource> GetCost()
        {
            return new List<Resource> { new Wood(100), new Workforce(50) };
        }
    }
}