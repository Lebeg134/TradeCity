﻿using System.Collections;

namespace TradeCity.Engine.Utilities
{
    internal static class LebegUtil
    {
        public static int IndexInRange(ICollection collection, int index)
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
        public static float Clamp(float num, float min, float max)
        {
            if (num < min)
                return min;
            if (num > max)
                return max;
            return num;
        }
    }
}
