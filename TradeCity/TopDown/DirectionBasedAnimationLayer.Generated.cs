
using System.Linq;

namespace JHP4SD.TopDown
{
    public class DirectionBasedAnimationLayer : FlatRedBall.Graphics.Animation.AnimationLayer
    {
        public string LastAnimation { get; set; }
        public TopDown.ITopDownEntity TopDownEntity { get; set; }

        public DirectionBasedAnimationLayer() 
        {
            this.EveryFrameAction = DoAnimationLogic;
        }

        private string DoAnimationLogic()
        {
            var currentSpeed = System.Math.Sqrt(TopDownEntity.XVelocity * TopDownEntity.XVelocity + TopDownEntity.YVelocity * TopDownEntity.YVelocity);

            AnimationSet setToUse = null;
            var animationSets = TopDownEntity.AnimationSets;

            for(int i = animationSets.Count - 1; i > -1; i--)
            {
                var possibleSet = animationSets[i];
                if(possibleSet.MovementValueName == TopDownEntity.CurrentMovement?.Name && possibleSet.MinSpeed <= currentSpeed)
                {
                    setToUse = possibleSet;
                    break;
                }
            }

            if(setToUse == null)
            {
                for (int i = animationSets.Count - 1; i > -1; i--)
                {
                    var possibleSet = animationSets[i];
                    if (possibleSet.MovementValueName == "Base Animations" && possibleSet.MinSpeed <= currentSpeed)
                    {
                        setToUse = possibleSet;
                        break;
                    }
                }
            }


            if(setToUse == null)
            {
                return null;
            }
            else
            {
                string currentAnimation = null;
                switch(TopDownEntity.DirectionFacing)
                {
                    case Entities.TopDownDirection.UpLeft:
                        currentAnimation = setToUse.UpLeftAnimationName;
                        break;
                    case Entities.TopDownDirection.Up:
                        currentAnimation = setToUse.UpAnimationName;
                        break;
                    case Entities.TopDownDirection.UpRight:
                        currentAnimation = setToUse.UpRightAnimationName;
                        break;

                    case Entities.TopDownDirection.Left:
                        currentAnimation = setToUse.LeftAnimationName;
                        break;
                    case Entities.TopDownDirection.Right:
                        currentAnimation = setToUse.RightAnimationName;
                        break;

                    case Entities.TopDownDirection.DownLeft:
                        currentAnimation = setToUse.DownLeftAnimationName;
                        break;
                    case Entities.TopDownDirection.Down:
                        currentAnimation = setToUse.DownAnimationName;
                        break;
                    case Entities.TopDownDirection.DownRight:
                        currentAnimation = setToUse.DownRightAnimationName;
                        break;
                }
                // If the animation to assign isn't set, use the last animation...
                currentAnimation = currentAnimation ?? LastAnimation;
                // ...however the last animation may have come from a different
                // set (like if the player was walking diagonally but then stopped
                // and is now idle.
                var isAnimationContained = setToUse.Contains(currentAnimation);
                // If it isn't contained, then find the closest
                if(isAnimationContained == false)
                {
                    switch (TopDownEntity.DirectionFacing)
                    {
                        case Entities.TopDownDirection.UpLeft:
                            currentAnimation = setToUse.LeftAnimationName ?? setToUse.UpAnimationName;
                            break;
                        case Entities.TopDownDirection.Up:
                            currentAnimation = setToUse.RightAnimationName ?? setToUse.LeftAnimationName;
                            break;
                        case Entities.TopDownDirection.UpRight:
                            currentAnimation = setToUse.RightAnimationName ?? setToUse.UpAnimationName;
                            break;

                        case Entities.TopDownDirection.Left:
                            currentAnimation = setToUse.DownAnimationName ?? setToUse.UpAnimationName;
                            break;
                        case Entities.TopDownDirection.Right:
                            currentAnimation = setToUse.DownAnimationName ?? setToUse.UpAnimationName;
                            break;

                        case Entities.TopDownDirection.DownLeft:
                            currentAnimation = setToUse.LeftAnimationName ?? setToUse.DownAnimationName;
                            break;
                        case Entities.TopDownDirection.Down:
                            currentAnimation = setToUse.RightAnimationName ?? setToUse.LeftAnimationName;
                            break;
                        case Entities.TopDownDirection.DownRight:
                            currentAnimation = setToUse.RightAnimationName ?? setToUse.DownAnimationName;
                            break;
                    }
                }

                LastAnimation = currentAnimation;

                return currentAnimation;
            }
        }
    }
}
