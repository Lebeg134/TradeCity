/**
 * @(#) IPlayerStrategy.cs
 */

namespace Lebeg134.Module.Session
{
    public interface IPlayerStrategy
    {
        void freeze();
        void unFreeze();
        bool isFrozen();
        void goBankrupt();
        void tick();
    }

}
