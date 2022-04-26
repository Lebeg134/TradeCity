

using System;
/**
* @(#) IPlayerStrategy.cs
*/
namespace Lebeg134.Module.Session
{
    public interface IPlayerStrategy
    {
        void Freeze();
        void UnFreeze(IPlayerStrategy newStrategy);
        bool IsFrozen();
        void GoBankrupt();
        void Tick();
    }

}
