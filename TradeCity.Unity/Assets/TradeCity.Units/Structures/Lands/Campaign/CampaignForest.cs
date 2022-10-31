using System.Collections.Generic;
using TradeCity.Engine.Resources;
using TradeCity.Engine.Structures;
using TradeCity.Units.Resources.Common;

namespace TradeCity.Units.Structures.Lands.Campaign
{
    public class CampaignForest:Land
    {
        public override string GetName()
        {
            return "Forest";
        }

        protected override int GetMaxLevel()
        {
            return 5;
        }

        protected override List<Resource> GetCost(int level)
        {
            return new List<Resource>()
            {

            };
        }

        public override Land GetNew()
        {
            return new CampaignForest();
        }

        protected override List<Resource> GetProduce(int level)
        {
            return new List<Resource>()
            {
                new Wood(100),
                new Wood(200),
                new Wood(500),
                new Wood(1000),
                new Wood(2500)
            };
        }
    }
}