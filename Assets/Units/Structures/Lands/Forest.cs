using Lebeg134.Module.Resources;
using Lebeg134.Module.Structures;
using Lebeg134.Module.Utilities;
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
        protected static List<Resource>[] UpgradeLevelsCostStats
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

        protected static List<Resource>[] ProductionLevelStats
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

        public override string GetName()
        {
            return "Forest";
        }
        public override string GetResourcepath()
        {
            return GetBasePath() + "Forest";
        }

        public override Land GetNew()
        {
            return new Forest();
        }

        protected override List<Resource> ProductionLevels(int level)
        {
            return ProductionLevelStats[LebegUtil.IndexInRange(ProductionLevelStats, level - 1)];
        }

        protected override List<Resource> UpgradeLevelsCosts(int level)
        {
            throw new System.NotImplementedException();
        }
    }

}
