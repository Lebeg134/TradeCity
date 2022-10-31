using System;

namespace TradeCity.Engine.Structures.Interfaces
{
    public interface IUpgradeable
    {
        bool CanUpgrade();
        void Upgrade();
    }
}