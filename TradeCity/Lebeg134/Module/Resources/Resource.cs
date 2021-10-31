/**
* @(#) Resource.cs
*/
using System;
using System.Runtime.Serialization;

namespace Lebeg134.Module.Resources
{
    public abstract class Resource
    {
        static readonly int id = 0;
        int stock;
        public Resource(int amount = 0)
        {
            if (amount >= 0)
                stock = amount;
            else
                stock = 0;
        }
        public void gain(int amount)
        {
            stock += amount;
        }

        public void spend(int amount)
        {
            if (stock >= amount)
                stock -= amount;
            else throw new NotEnoughResourceException();
        }
        protected Resource Add(Resource B)
        {
            gain(B.stock);
            return this;
        }
        protected Resource Sub(Resource B)
        {
            spend(B.stock);
            return this;
        }
        public static Resource operator +(Resource A, Resource B)
        {
            return A.Add(B);
        }
        public static Resource operator -(Resource A, Resource B)
        {
            return A.Sub(B);
        }
    }

    [Serializable]
    internal class NotEnoughResourceException : Exception { }
}
