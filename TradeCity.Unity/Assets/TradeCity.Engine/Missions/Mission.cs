using System;
using TradeCity.Engine.Session;
using TradeCity.Engine.TimeManager;

namespace TradeCity.Engine.Missions
{
    [Serializable]
    public class Mission : ITickable
    {
        //public event Action OnProgress;
        public event Action OnAchievement;
        public event Action OnClaim;

        private Player owner;
        private readonly IAchievable goal;
        private readonly IRewardable reward;
        private bool isAccepted = false;
        private bool isAchieved = false;
        private bool isClaimed = false;
        //Enum state? Strategy?

        public string Text => goal.Text;
        public bool IsAccepted => isAccepted;
        public bool IsAchieved => goal.IsAchieved();
        public bool IsClaimed => isClaimed;

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
                isClaimed = true;
                OnClaim?.Invoke();
            }
        }
        public void Accept(Player by)
        {
            owner = by;
            goal.Accept(by);
            isAccepted = true;
            Register();
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
                OnAchievement?.Invoke();
            }
        }

        public void Tick()
        {
            Check();
        }
    }
}