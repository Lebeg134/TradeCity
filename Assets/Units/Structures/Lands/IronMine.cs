using Lebeg134.Module.Resources;
using Lebeg134.Module.Structures;
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
        public override string GetName()
        {
            return "Iron Mine";
        }
        public override string GetResourcepath()
        {
            return GetBasePath() + "IronMine";
        }
        public override Land GetNew()
        {
            return new IronMine();
        }

        protected override List<Resource> GetProduce(int level)
        {
            return new List<Resource> { new Iron(10) };
        }

        protected override List<Resource> GetCost(int level)
        {
            return new List<Resource> { new Money(100 * level + 250) };
        }
    }

}
