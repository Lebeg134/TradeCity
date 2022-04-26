using Lebeg134.Module.Resources;
using Lebeg134.Module.Structures;
using Lebeg134.Units;
using Lebeg134.Resources.ConstructionIndustry;
using Lebeg134.Resources.EnergySector;
using Lebeg134.Resources.Workforce;
using System;
using System.Collections.Generic;
/**
* @(#) GlassKiln.cs
*/
namespace Lebeg134.Structures.ConstructionIndustry
{
    [Serializable]
    public class GlassKiln : CommonProdBuilding
    {
        public override List<IOwnable> Criteria()
        {
            return new List<IOwnable> { new CraftsmanHQ() };
        }

        public override Branches GetBranch()
        {
            return Branches.CONSTRUCTION;
        }

        public override int GetMaxLevel()
        {
            return 10;
        }

        public override string GetName()
        {
            return "Glass Kiln";
        }

        public override List<Resource> GetProduce()
        {
            return new List<Resource> { new Glass(5 * level) };
        }

        public override List<Resource> GetUpkeep()
        {
            return new List<Resource> { new Sand(25 * level), new Electricity(25* level) };
        }

        public override List<Resource> UpgradeLevelsCosts(int level)
        {
            if (level == 0)
                return new List<Resource> { new Bricks(150), new Workforce(25) };
            else
                return new List<Resource> { new Bricks(100 * level), Concrete(50 * level) };
        }

        private Resource Concrete(int v)
        {
            throw new NotImplementedException();
        }
    }

}
