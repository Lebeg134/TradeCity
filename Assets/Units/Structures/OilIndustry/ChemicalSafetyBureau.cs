using Lebeg134.Module.Resources;
using Lebeg134.Module.Structures;
using Lebeg134.Units;
using Lebeg134.Resources.ConstructionIndustry;
using Lebeg134.Resources.EnergySector;
using Lebeg134.Resources.Workforce;
using System;
using System.Collections.Generic;
/**
* @(#) ChemicalSafetyBureau.cs
*/
namespace Lebeg134.Structures.OilIndustry
{
    [Serializable]
    public class ChemicalSafetyBureau : SpecialBuilding
    {
        public override List<Resource> Cost()
        {
            return new List<Resource> { new Bricks(250), new Workforce(25) };
        }

        public override List<IOwnable> Criteria()
        {
            return new List<IOwnable>();
        }

        public override Branches getBranch()
        {
            return Branches.OIL;
        }

        public override string getName()
        {
            return "Chemical Safety Bureau";
        }

        public override List<Resource> getUpkeep()
        {
            return new List<Resource> { new Electricity(5) };
        }
    }

}
