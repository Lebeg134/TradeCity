/**
* @(#) Resource.cs
*/
using Lebeg134.Module.Graphics;
using System;
using System.Collections.Generic;

namespace Lebeg134.Module.Resources
{
    [Serializable]
    public abstract class Resource: IGetRes
    {
        public static VisualUpdater updater = new VisualUpdater();

        //Amount of resource stored
        protected int stock;
        public Resource(int amount = 0)
        {
            if (amount > 0)
                stock = amount;
            else
                stock = 0;
        }
        virtual public string GetResourcepath()
        {
            //Default icon is money stack
            return "Resource/money-stack";
        }
        protected string BasePath()
        {
            return "Resource/";
        }
        public int amount()
        {
            return stock;
        }
        public abstract String GetName();

        public virtual void gain(int amount)
        {
            if (amount < 0)
            {
                throw new ArgumentException("Can not gain negative amount");
            }
            stock += amount;
        }
        public virtual void spend(int amount)
        {
            if (amount < 0)
            {
                throw new ArgumentException("Can not spend negative amount");
            }
            if (stock >= amount)
            {
                stock -= amount;
            }
            else throw new NotEnoughResourceException();
        }
        public virtual void setAmount(int amount)
        {
            if (amount < 0)
            {
                throw new ArgumentException("Can not set negative amount");
            }
            stock = amount;
        }
        public abstract Resource getNewResource(int amount);
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
    internal class NotEnoughResourceException : Exception
    {
        List<Resource> missingResources;
        public NotEnoughResourceException(List<Resource> missingResources = null)
        {
            this.missingResources = missingResources;
        }
    }
}
