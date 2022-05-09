using System;

namespace Lebeg134.Module.Structures
{
    public interface IUpgradeable
    {
        event Action<Structure> OnUpgrade;
        event Action<Structure> OnMaxLevelReached;
        bool CanUpgrade();
        void Upgrade();
    }
}