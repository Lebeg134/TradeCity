﻿using System.Collections.Generic;
using TradeCity.Engine.Resources;
using TradeCity.Engine.Structures;

namespace TradeCity.Units.Structures.Town
{
    public class Shops: Building
    {
        public override string GetName()
        {
            return "Shops";
        }

        public override Branches GetBranch()
        {
            return Branches.Town;
        }

        protected override int GetMaxLevel()
        {
            throw new System.NotImplementedException();
        }

        protected override List<Resource> GetCost(int level)
        {
            throw new System.NotImplementedException();
        }
    }
}