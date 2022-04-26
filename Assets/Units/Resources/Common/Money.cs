using Lebeg134.Module.Resources;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lebeg134.Units.Resources.Common
{
    [Serializable]
    class Money : StandardResource
    {
        public Money(int amount) : base(amount) { }

        public override string GetName()
        {
            return "Money";
        }
        public override string GetResourcepath()
        {
            return BasePath() + "money-stack";
        }

        public override Resource getNewResource(int amount)
        {
            return new Money(amount);
        }

        public override double GetValue()
        {
            return 1;
        }
    }
}
