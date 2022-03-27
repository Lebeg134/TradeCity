using JHP4SD.Lebeg134.Module.Resources;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JHP4SD.Lebeg134.Units.Resources.Common
{
    [Serializable]
    class Money : StandardResource
    {
        public Money(int amount) : base(amount) { }

        public override string getName()
        {
            return "Money";
        }

        public override Resource getNewResource(int amount)
        {
            return new Money(amount);
        }

        public override double getValue()
        {
            return 1;
        }
    }
}
