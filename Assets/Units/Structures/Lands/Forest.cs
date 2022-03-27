using JHP4SD.Lebeg134.Module.Resources;
using JHP4SD.Lebeg134.Module.Structures;
using JHP4SD.Lebeg134.Module.Utilities;
using Lebeg134.Resources.Common;
using System;
using System.Collections.Generic;
/**
* @(#) Forest.cs
*/
namespace Lebeg134.Structures.Lands
{
    [Serializable]
    public class Forest : Land
    {
        protected static List<Resource>[] upgradeLevelsCostStats
        {
            get
            {
                return new[] {
                    new List<Resource> {new Wood(100)},
                    new List<Resource> {new Wood(200)},
                    new List<Resource> {new Wood(300)},
                    new List<Resource> {new Wood(400)},
                    new List<Resource> {new Wood(500)},
                    new List<Resource> {new Wood(600)},
                    new List<Resource> {new Wood(700)},
                    new List<Resource> {new Wood(800)},
                    new List<Resource> {new Wood(900)},
                    new List<Resource> {new Wood(1000)}
                };
            }
        }

        protected static List<Resource>[] productionLevelStats
        {
            get
            {
                return new[] 
                {
                    new List<Resource> {new Wood(10)},
                    new List<Resource> {new Wood(20)},
                    new List<Resource> {new Wood(30)},
                    new List<Resource> {new Wood(40)},
                    new List<Resource> {new Wood(50)},
                    new List<Resource> {new Wood(60)},
                    new List<Resource> {new Wood(70)},
                    new List<Resource> {new Wood(80)},
                    new List<Resource> {new Wood(90)},
                    new List<Resource> {new Wood(100)}
                };
            }
        }

        public override string getName()
        {
            return "Forest";
        }

        public override Land GetNew()
        {
            return new Forest();
        }

        protected override List<Resource> productionLevels(int level)
        {
            return productionLevelStats[LebegUtil.indexInRange(productionLevelStats, level - 1)];
        }

        protected override List<Resource> upgradeLevelsCosts(int level)
        {
            throw new System.NotImplementedException();
        }
    }

}
