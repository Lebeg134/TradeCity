/**
* @(#) Land.cs
*/
using JHP4SD.GumRuntimes;
using JHP4SD.GumRuntimes.LebegForms.Resources;
using JHP4SD.Lebeg134.Module.Graphics;
using JHP4SD.Lebeg134.Module.MapNS;
using JHP4SD.Lebeg134.Module.Resources;
using JHP4SD.Lebeg134.Module.Session;
using JHP4SD.Lebeg134.Module.TimeManager;
using JHP4SD.Lebeg134.Units;
using System;
using System.Collections.Generic;

namespace JHP4SD.Lebeg134.Module.Structures
{
    [Serializable]
    public abstract class Land : Structure, IUpgradeable, IProducer, IOwnable, IMapStructure
    {
        public static int StartingPrice { get; set; }
        public static VisualUpdater landUpdater = new VisualUpdater();
        public static LandImagesRuntime spriteLibrary = new LandImagesRuntime();
        protected Player owner;
        protected int level = 1; //Leveling starts from 1
        private int _x = -1, _y = -1;

        public abstract Land GetNew();
        public bool Equals(Land A, Land B)
        {
            return A.GetType() == B.GetType() && A._x == B._x && A._y == B._y && A.owner == B.owner;
        }

        public int GetStartingPrice()
        {
            return StartingPrice;
        }
        public void acquire(Player by)
        {
            owner = by;
        }
        public bool hasOwner()
        {
            return owner != null;
        }
        public void levelUp()
        {
            if (owner.checkResources(upgradeLevelsCosts(level))) //Level is 1 higher than index used for level stats
                level++;
        }
        protected abstract List<Resource> upgradeLevelsCosts(int level);
        public List<Resource> getProduce()
        {
            return productionLevels(level - 1);
        }
        protected abstract List<Resource> productionLevels(int level);
        public void Produce()
        {
            ProducerStrategy.Produce(owner, this);
        }
        public void tick()
        {
            Produce();
        }
        public void register()
        {
            Clock.Instance.Register(this);
        }
        public void SetCoords(int x, int y)
        {
            _x = x;
            _y = y;
        }
        public virtual bool IsAuctionable()
        {
            return true;
        }
        public bool Equals(IMapStructure a, IMapStructure b)
        {
            if (a.GetType() == b.GetType())
                return ((Land)a).Equals((Land)b);
            else 
                return false;
        }
        public int GetHashCode(IMapStructure obj)
        {
            //Hash code generation based on the method given in Josh Bloch's Effective Java
            unchecked //we dont care if it overflows
            {
                int hash = 113;
                hash = hash * 53 + GetType().GetHashCode();
                hash = hash * 53 + _x.GetHashCode();
                hash = hash * 53 + _y.GetHashCode();
                if (owner != null)
                    hash = hash * 53 + owner.GetHashCode();
                return hash;
            }
        }
        public override bool Equals(Structure x, Structure y)
        {
            return Equals((Land)x, (Land)y);
        }
        public override int GetHashCode(Structure obj)
        {
            return GetHashCode((Land)obj);
        }

        public List<Resource> getUpkeep()
        {
            return new List<Resource>(); // No upkeep for lands
        }

        public int getMaxLevel()
        {
            return 10;
        }

        public int getLevel()
        {
            return level;
        }
    }
}
