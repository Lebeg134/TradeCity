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
    public interface IUpgradeable
    {
        BuildingState BuildingState { get; }
        int Level { get; }
        void LevelUp();
        int REPLACEMEGetMaxLevel();
        // TODO Remove!!
        int REPLACEMEGetLevel();
    }
}
