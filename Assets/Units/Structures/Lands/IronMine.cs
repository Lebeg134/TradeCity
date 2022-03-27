using JHP4SD.Lebeg134.Module.Resources;
using JHP4SD.Lebeg134.Module.Structures;
using JHP4SD.Lebeg134.Units.Resources.Common;
using Lebeg134.Resources.Common;
using System;
using System.Collections.Generic;
/**
* @(#) IronMine.cs
*/
namespace Lebeg134.Structures.Lands
{
    [Serializable]
    public class IronMine : Land
    {
        public override string getName()
        {
            return "Iron Mine";
        }

        public override Land GetNew()
        {
            return new IronMine();
        }

        protected override List<Resource> productionLevels(int level)
        {
            return new List<Resource> { new Iron(10) };
        }

        protected override List<Resource> upgradeLevelsCosts(int level)
        {
            return new List<Resource> { new Money(100 * level + 250) };
        }
    }

}
