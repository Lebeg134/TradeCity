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
    public interface IBuilding
    {
        BuildingState BuildingState { get; }
        int Level { get; }
        int MaxLevel { get; }
        void LevelUp();
    }
}
