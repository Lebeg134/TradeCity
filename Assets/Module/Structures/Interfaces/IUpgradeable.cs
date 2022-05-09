using Lebeg134.Module.Resources;
using System;
using System.Collections.Generic;

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