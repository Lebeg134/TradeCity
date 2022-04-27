/**
 * @(#) IUpgradeable.cs
 */

namespace Lebeg134.Module.Structures
{
    public interface IUpgradeable
    {
        void LevelUp();
        int GetMaxLevel();
        int GetLevel();
    }
}
