/**
* @(#) Land.cs
*/
using Assets.Module.Structures;
using Lebeg134.Module.MapNS;
using Lebeg134.Module.Resources;
using Lebeg134.Module.Session;
using Lebeg134.Module.TimeManager;
using System;
using System.Collections.Generic;

namespace Lebeg134.Module.Structures
{
    [Serializable]
    public abstract class Land : RecipeHolderLevelableStructure, IProducer, IOwnable, IMapStructure
    {
        public static int StartingPrice { get; set; }
        protected Player owner;
        protected int level = 1; //Leveling starts from 1
        private int x = -1, y = -1;

        public abstract Land GetNew();
        public bool Equals(Land A, Land B)
        {
            return A.GetType() == B.GetType() && A.x == B.x && A.y == B.y && A.owner == B.owner;
        }

        public int GetStartingPrice()
        {
            return StartingPrice;
        }
        public void Acquire(Player by)
        {
            owner = by;
        }
        public bool HasOwner()
        {
            return owner != null;
        }
        public void LevelUp()
        {
            if (owner.CheckResources(UpgradeLevelsCosts(level))) //Level is 1 higher than index used for level stats
                level++;
        }
        protected abstract List<Resource> UpgradeLevelsCosts(int level);
        public List<Resource> GetProduce()
        {
            return ProductionLevels(level - 1);
        }
        protected abstract List<Resource> ProductionLevels(int level);
        public void Produce()
        {
            ProducerStrategy.Produce(owner, this);
        }
        public void Tick()
        {
            Produce();
        }
        public void Register()
        {
            Clock.Instance.Register(this);
        }
        public void SetCoords(int x, int y)
        {
            this.x = x;
            this.y = y;
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
                hash = hash * 53 + x.GetHashCode();
                hash = hash * 53 + y.GetHashCode();
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

        public List<Resource> GetUpkeep()
        {
            return new List<Resource>(); // No upkeep for lands
        }

        public int GetMaxLevel()
        {
            return 10;
        }

        public int REPLACEMEGetLevel()
        {
            return level;
        }

        override protected string GetBasePath()
        {
            return base.GetBasePath() + "Land/";
        }
    }
}
