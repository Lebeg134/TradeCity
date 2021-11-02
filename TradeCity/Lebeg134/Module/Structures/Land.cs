/**
* @(#) Land.cs
*/
using Lebeg134.Module.MapNS;
using Lebeg134.Module.Resources;
using Lebeg134.Module.Session;
using Lebeg134.Module.TimeManager;
using System.Collections.Generic;

namespace Lebeg134.Module.Structures
{
    public class Land : Structure, IUpgradeable, IProducer, IOwnable, IMapStructure
    {
        protected static readonly List<Resource>[] upgradeLevelsCosts;
        protected static readonly List<Resource>[] productionLevels;
        public static int StartingPrice { get; set; }
        protected Player owner;
        protected int level = 1; //Leveling starts from 1
        private int _x = -1, _y = -1;

        public Land()
        {
            register();
        }
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
        public void levelUp()
        {
            if (owner.checkResources(upgradeLevelsCosts[level])) //Level is 1 higher than index used for level stats
                level++;
        }
        public List<Resource> getProduce()
        {
            return productionLevels[level - 1];
        }
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
    }
}
