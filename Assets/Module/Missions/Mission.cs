using Lebeg134.Module.Session;
using Lebeg134.Module.TimeManager;
using System;

namespace Lebeg134.Module.Missions
{
    public class Mission : ITickable
    {
        public event Action OnAchievement;
        public event Action OnClaim;

        private Player owner;
        private IAchievable goal;
        private IRewardable reward;
        private bool isAccepted = false;
        private bool isAchieved = false;
        private bool isClaimed = false;
        //Enum state? Strategy?

        public string Text { get { return goal.Text; } }
        public bool IsAccepted { get { return isAccepted; } }
        public bool IsAchieved { get { return isAchieved; } }
        public bool IsClaimed { get { return isClaimed; } }

        public Mission(IAchievable goal, IRewardable reward, Player owner = null)
        {
            this.goal = goal;
            this.reward = reward;
            goal.OnAchieve += Check;
            this.owner = owner;
            if (owner != null)
            {
                Accept(owner);
            }
        }

        public float CheckStatus()
        {
            return goal.CheckStatus();
        }

        public void Claim()
        {
            if (isAchieved)
            {
                reward.Reward(owner);
                OnClaim.Invoke();
            }
            else
                throw new MissionNotAchievedException();
        }
        public void Accept(Player by)
        {
            owner = by;
            goal.Accept(by);
            isAccepted = true;
        }

        public void Register()
        {
            Clock.Instance.Register(this);
        }

        public void Check()
        {
            if (isAccepted && !isAchieved && goal.IsAchieved())
            {
                isAchieved = true;
                OnAchievement.Invoke();
            }
        }

        public void Tick()
        {
            Check();
        }
    }
}