using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lebeg134.Module.Utilities
{
    static class LebegUtil
    {
        public static int indexInRange(ICollection collection, int index)
        {
            int i = 0;
            if (index < 0)
                i = 0;
            else if (index > collection.Count)
                i = collection.Count;
            else
                i = index;
            return i;
        }
    }
}
