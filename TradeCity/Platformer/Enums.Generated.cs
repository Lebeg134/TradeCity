


namespace JHP4SD.Entities
{
    public enum MovementType
    {
        Ground,
        Air,
        AfterDoubleJump
    }
    public enum HorizontalDirection
    {
        Left,
        Right
    }

    public static class HorizontalDirectionExtensions
    {
        public static HorizontalDirection GetInverse(this HorizontalDirection direction)
        {
            return direction == HorizontalDirection.Left ?
                HorizontalDirection.Right :
                HorizontalDirection.Left;
        }
    }
}

