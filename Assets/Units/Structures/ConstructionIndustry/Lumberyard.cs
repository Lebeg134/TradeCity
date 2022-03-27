

using JHP4SD.GumRuntimes;
using JHP4SD.Lebeg134.Module.Resources;
using JHP4SD.Lebeg134.Module.Structures;
using JHP4SD.Lebeg134.Units;
using Lebeg134.Resources.Common;
using Lebeg134.Resources.ConstructionIndustry;
using Lebeg134.Resources.EnergySector;
using Lebeg134.Resources.Workforce;
using System;
using System.Collections.Generic;
/**
* @(#) Lumberyard.cs
*/
namespace Lebeg134.Structures.ConstructionIndustry
{
    [Serializable]
    public class Lumberyard : CommonProdBuilding
    {
        public override List<IOwnable> Criteria()
        {
            return new List<IOwnable>();
        }

        public override Branches getBranch()
        {
            return Branches.CONSTRUCTION;
        }

        public override int getMaxLevel()
        {
            return 20;
        }

        public override string getName()
        {
            return "Lumberyard";
        }

        public override List<Resource> getProduce()
        {
            throw new NotImplementedException();
        }

        public override SpriteRuntime GetSprite()
        {
            return spriteLibrarySmall.DefaultSprite;
        }

        public override List<Resource> getUpkeep()
        {
            return new List<Resource> { new Wood(3*level), new Electricity(2*level) };
        }

        public override List<Resource> upgradeLevelsCosts(int level)
        {
            if (level == 0)
                return new List<Resource> { new Wood(100), new Workforce(10) };
            else if (level < 10)
                return new List<Resource> { new Lumber(50 * level), new Workforce(5) };
            else
                return new List<Resource> { new Concrete(50 * level), new Workforce(2) };
        }
    }

}
