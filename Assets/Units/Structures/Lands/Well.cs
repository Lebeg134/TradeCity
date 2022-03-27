using JHP4SD.Lebeg134.Module.Resources;
using JHP4SD.Lebeg134.Module.Structures;
using JHP4SD.Lebeg134.Units.Resources.Common;
using Lebeg134.Resources.Common;
using System;
using System.Collections.Generic;
/**
* @(#) Well.cs
*/
namespace Lebeg134.Structures.Lands
{
    [Serializable]
    public class Well : Land
    {
        public override string getName()
        {
            return "Pumping Station";
        }

        public override Land GetNew()
        {
            return new Well();
        }

        protected override List<Resource> productionLevels(int level)
        {
            return new List<Resource>() { new Water(10) };
        }

        protected override List<Resource> upgradeLevelsCosts(int level)
        {
            return new List<Resource>() { new Money(100 * level) };
        }
    }

}