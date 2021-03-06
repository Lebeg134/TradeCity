/**
* @(#) Resource.cs
*/
using Lebeg134.Module.Graphics;
using Lebeg134.Module.TimeManager;
using System;
using System.Collections.Generic;

namespace Lebeg134.Module.Resources
{
    [Serializable]
    public abstract class Resource : IGetRes, ITickable
    {
        public event Action<int> OnAmountChange;
        //Amount of resource stored
        protected int stock;
        public Resource(int amount = 0)
        {
            if (amount > 0)
                stock = amount;
            else
                stock = 0;
        }
        public int GetStock()
        {
            return stock;
        }
        public abstract string GetName();
        virtual public string GetResourcepath()
        {
            //Default icon is money stack
            return "Resource/unknown";
        }
        protected string BasePath()
        {
            return "Resource/";
        }

        public virtual Resource Gain(int amount)
        {
            if (amount < 0)
            {
                throw new ArgumentException("Can not gain negative amount");
            }
            stock += amount;
            OnAmountChange?.Invoke(amount);
            return this;
        }
        public virtual Resource Spend(int amount)
        {
            if (amount < 0)
            {
                throw new ArgumentException("Can not spend negative amount");
            }
            if (stock >= amount)
            {
                stock -= amount;
                OnAmountChange?.Invoke(-amount);
            }
            else throw new NotEnoughResourceException();
            return this;
        }
        public virtual void SetStock(int amount)
        {
            if (amount < 0)
            {
                throw new ArgumentException("Can not set negative amount");
            }
            int prevStock = stock;
            stock = amount;
            OnAmountChange?.Invoke(stock - prevStock);
        }
        public abstract Resource GetNewResource(int amount);

        public virtual void Tick()
        {
            //do nothing by default
        }

        public void Register()
        {
            //Cannot be directly registered
        }

        public static Resource operator +(Resource A, Resource B)
        {
            if (A.GetType() != B.GetType()) throw new ArgumentException("Not same Type!");
            return A.Gain(B.stock);
        }
        public static Resource operator -(Resource A, Resource B)
        {
            if (A.GetType() != B.GetType()) throw new ArgumentException("Not same Type!");
            return A.Spend(B.stock);
        }
        public static Resource operator +(Resource A, int B)
        {
            return A.Gain(B);
        }
        public static Resource operator-(Resource A, int B)
        {
            return A.Spend(B);
        }
        public static List<Resource> operator +(List<Resource> list, Resource B)
        {
            foreach (Resource A in list)
            {
                if (A.GetName() == B.GetName())
                {
                    A.Gain(B.stock);
                }
            }
            return list;
        }
        public static void Transfer(Resource to, Resource from, int amount, bool safe = false)
        {
            if (safe && amount > from.GetStock())
                amount = from.GetStock();
            from.Spend(amount);
            to.Gain(amount);
        }
        public static void Transfer(Resource to, Resource from, bool safe = false)
        {
            Transfer(to, from, from.GetStock(), safe);
        }
        public static void Transfer(List<Resource> to, Resource from, int amount, bool safe = false)
        {
            foreach(Resource res in to)
            {
                if (res.GetType() == from.GetType())
                {
                    Transfer(res, from, amount, safe);
                    return;
                }
            }
            Resource newRes = from.GetNewResource(0);
            Transfer(newRes, from, amount, safe);
            to.Add(newRes);
        }
        public static void Transfer(List<Resource> to, Resource from, bool safe = false)
        {
            Transfer(to, from, from.GetStock(), safe);
        }
        public static void Transfer(List<Resource> to, List<Resource> from, bool safe = false)
        {
            foreach (Resource res in from)
            {
                Transfer(to, res, safe);
            }
        }
        public static int GetStock(List<Resource> list, Resource type)
        {
            int stockSum = 0;
            foreach(Resource res in list)
            {
                if (res.GetType() == type.GetType())
                    stockSum += res.GetStock();
            }
            return stockSum;
        }

        [Serializable]
        internal class NotEnoughResourceException : Exception
        {
            List<Resource> missingResources;
            public NotEnoughResourceException(List<Resource> missingResources = null)
            {
                this.missingResources = missingResources;
            }
        }
    }
}
