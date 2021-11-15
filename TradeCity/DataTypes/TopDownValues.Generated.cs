
namespace JHP4SD.DataTypes
{
    public partial class TopDownValues
    {
        public string Name;
        public bool UsesAcceleration;
        public float MaxSpeed;
        public float AccelerationTime;
        public float DecelerationTime;
        public bool UpdateDirectionFromVelocity;
        public bool UpdateDirectionFromInput;
        public bool IsUsingCustomDeceleration;
        public float CustomDecelerationValue;
        public int InheritOrOverwriteAsInt;
        public const string Default = "Default";
        public static System.Collections.Generic.List<System.String> OrderedList = new System.Collections.Generic.List<System.String>
        {
        Default
        };
        
        
    }
}
