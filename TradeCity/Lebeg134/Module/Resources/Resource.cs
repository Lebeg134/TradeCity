/**
* @(#) Resource.cs
*/
using Gum.Managers;
using JHP4SD.GumRuntimes;
using JHP4SD.GumRuntimes.LebegForms.Resources;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;

namespace JHP4SD.Lebeg134.Module.Resources
{
    public abstract class Resource
    {
        public static ResourceIconsRuntime spriteLibrary = new ResourceIconsRuntime();
        private const string basePath = "Content/GlobalContent/Resources/ResourceIcons";

        //ID used to identify resource
        //static readonly int id = 0; Might not even be needed
        //Amount of resource stored
        protected int stock;
        public Resource(int amount = 0)
        {
            if (amount > 0)
                stock = amount;
            else
                stock = 0;
        }
        public int amount()
        {
            return stock;
        }
        public abstract String getName();
        public abstract SpriteRuntime getSprite();

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
                stock -= amount;
            else throw new NotEnoughResourceException();
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
