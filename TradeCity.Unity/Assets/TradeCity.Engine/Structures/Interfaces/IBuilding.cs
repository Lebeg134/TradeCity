using Lebeg134.Module.Resources;
using Lebeg134.Module.Session;
using Lebeg134.Module.TimeManager;
using System;
using System.Collections.Generic;
/**
* @(#) IUpgradeable.cs
*/
namespace Lebeg134.Module.Structures
{
    public enum BuildingState
    {
        BUILD,
        UPGRADE,
        MAXLEVEL
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
