using System;
using System.Collections.Generic;
using TradeCity.Engine.TimeManager;

namespace TradeCity.Engine.Resources
{
    [Serializable]
    public abstract class Resource : ITickable
    {
        public event Action<int> OnAmountChange;
        //Amount of resource stored
        protected int _stock;
        public Resource(int amount = 0)
        {
            if (amount > 0)
                _stock = amount;
            else
                _stock = 0;
        }
        public int GetStock()
        {
            return _stock;
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
            _stock += amount;
            OnAmountChange?.Invoke(amount);
            return this;
        }
        public virtual Resource Spend(int amount)
        {
            if (amount < 0)
            {
                throw new ArgumentException("Can not spend negative amount");
            }
            if (_stock >= amount)
            {
                _stock -= amount;
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
            var prevStock = _stock;
            _stock = amount;
            OnAmountChange?.Invoke(_stock - prevStock);
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

        public static Resource operator +(Resource a, Resource b)
        {
            if (a.GetType() != b.GetType()) throw new ArgumentException("Not same Type!");
            return a.Gain(b._stock);
        }
        public static Resource operator -(Resource a, Resource b)
        {
            if (a.GetType() != b.GetType()) throw new ArgumentException("Not same Type!");
            return a.Spend(b._stock);
        }
        public static Resource operator +(Resource a, int b)
        {
            return a.Gain(b);
        }
        public static Resource operator -(Resource a, int b)
        {
            return a.Spend(b);
        }
        public static List<Resource> operator +(List<Resource> list, Resource b)
        {
            foreach (var a in list)
            {
                if (a.GetName() == b.GetName())
                {
                    a.Gain(b._stock);
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
            foreach (var res in to)
            {
                if (res.GetType() == from.GetType())
                {
                    Transfer(res, from, amount, safe);
                    return;
                }
            }
            var newRes = from.GetNewResource(0);
            Transfer(newRes, from, amount, safe);
            to.Add(newRes);
        }
        public static void Transfer(List<Resource> to, Resource from, bool safe = false)
        {
            Transfer(to, from, from.GetStock(), safe);
        }
        public static void Transfer(List<Resource> to, List<Resource> from, bool safe = false)
        {
            foreach (var res in from)
            {
                Transfer(to, res, safe);
            }
        }
        public static int GetStock(List<Resource> list, Resource type)
        {
            var stockSum = 0;
            foreach (var res in list)
            {
                if (res.GetType() == type.GetType())
                    stockSum += res.GetStock();
            }
            return stockSum;
        }

        [Serializable]
        internal class NotEnoughResourceException : Exception
        {
            private readonly List<Resource> _missingResources;
            public NotEnoughResourceException(List<Resource> missingResources = null)
            {
                _missingResources = missingResources;
            }
        }
    }
}
