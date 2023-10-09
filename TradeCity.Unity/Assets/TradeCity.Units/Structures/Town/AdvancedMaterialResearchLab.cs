/**
 * @(#) AdvancedMaterialResearchLab.cs
 */

using System.Collections.Generic;
using TradeCity.Engine.Resources;
using TradeCity.Engine.Structures.EasyInheritance;
using TradeCity.Engine.Structures.Interfaces;

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

        public override List<Resource> GetUpkeep()
        {
            throw new System.NotImplementedException();
        }

        public override List<Resource> GetCost()
        {
            throw new System.NotImplementedException();
        }

        public override List<IOwnable> GetCriteria()
        {
            throw new System.NotImplementedException();
        }
    }
}