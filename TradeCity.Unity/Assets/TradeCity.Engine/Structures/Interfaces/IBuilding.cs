using System;
using System.Collections.Generic;
using TradeCity.Engine.Resources;
using TradeCity.Engine.Session;
using TradeCity.Engine.TimeManager;

namespace TradeCity.Engine.Structures.Interfaces
{
    public enum BuildingState
    {
        Build,
        Upgrade,
        Maxlevel
    }
    public interface IBuilding : IProducer, IOwnable, IUpgradeable, ITickable
    {
        public event Action<Building> OnBuild;
        BuildingState BuildingState { get; }
        int Level { get; }
        int MaxLevel { get; }
        void Build(Player by);
        bool CanBuild(Player by);
        List<Resource> GetUpkeep();
        List<Resource> GetCost();
        List<IOwnable> GetCriteria();
    }
}