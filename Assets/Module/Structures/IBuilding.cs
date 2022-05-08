using Lebeg134.Module.Resources;
using Lebeg134.Module.Session;
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
    public interface IBuilding: IProducer
    {
        public event Action<Building> OnBuild;
        public event Action<Building> OnUpgrade;
        public event Action<Building> OnMaxLevelReached;
        BuildingState BuildingState { get; }
        int Level { get; }
        int MaxLevel { get; }
        void Build(Player by);
        bool CanBuild(Player by);
        void Upgrade();
        bool CanUpgrade();
        List<Resource> GetUpkeep();
    }
}
