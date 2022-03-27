

using System;
/**
* @(#) IPlayerStrategy.cs
*/
namespace JHP4SD.Lebeg134.Module.Session
{
    public interface IPlayerStrategy
    {
        void freeze();
        void unFreeze(IPlayerStrategy newStrategy);
        bool isFrozen();
        void goBankrupt();
        void tick();
    }

}
