

namespace JHP4SD.TopDown
{
    public class AnimationSet
    {
        public float MinSpeed { get; set; }
        public string MovementValueName { get; set; }

        public string UpLeftAnimationName { get; set; }
        public string UpAnimationName { get; set; }
        public string UpRightAnimationName { get; set; }

        public string LeftAnimationName { get; set; }
        public string RightAnimationName { get; set; }

        public string DownLeftAnimationName { get; set; }
        public string DownAnimationName { get; set; }
        public string DownRightAnimationName { get; set; }

        public override string ToString()
        {
            return $"{MovementValueName}";
        }

        public bool Contains(string animationName)
        {
            return
                UpLeftAnimationName == animationName ||
                UpAnimationName == animationName ||
                UpRightAnimationName == animationName ||
                LeftAnimationName == animationName ||
                RightAnimationName == animationName ||
                DownLeftAnimationName == animationName ||
                DownAnimationName == animationName ||
                DownRightAnimationName == animationName;
        }

    }
}
