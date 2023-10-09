/**
 * @(#) GasSafetyInstitute.cs
 */

using System.Collections.Generic;
using TradeCity.Engine.Resources;
using TradeCity.Engine.Structures.EasyInheritance;
using TradeCity.Engine.Structures.Interfaces;

namespace TradeCity.Units.Structures.EnergySector
{
    public class GasSafetyInstitute : SpecialBuilding
    {
        public override string GetName()
        {
            return "Gas Safety Institute";
        }

        public override Branches GetBranch()
        {
            return Branches.Energy;
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