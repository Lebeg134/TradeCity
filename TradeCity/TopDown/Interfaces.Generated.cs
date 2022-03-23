


namespace JHP4SD.TopDown
{
    public interface ITopDownEntity
    {
        DataTypes.TopDownValues CurrentMovement { get; }
        Entities.TopDownDirection DirectionFacing { get; }
        System.Collections.Generic.List<TopDown.AnimationSet> AnimationSets { get; }
        
        float XVelocity { get; set; }
        float YVelocity { get; set; }
    }
}
