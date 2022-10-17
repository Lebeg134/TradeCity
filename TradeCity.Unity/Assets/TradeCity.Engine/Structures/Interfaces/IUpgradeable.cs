using System;

namespace TradeCity.Engine.Structures.Interfaces
{
    public interface IUpgradeable
    {
        event Action<Structure> OnUpgrade;
        event Action<Structure> OnMaxLevelReached;
        bool CanUpgrade();
        void Upgrade();
    }
}