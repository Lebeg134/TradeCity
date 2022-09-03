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

        private Player _owner;
        private readonly IAchievable _goal;
        private readonly IRewardable _reward;
        private bool _isAccepted;
        private bool _isAchieved;
        private bool _isClaimed;
        //Enum state? Strategy?

        public string Text => _goal.Text;
        public bool IsAccepted => _isAccepted;
        public bool IsAchieved => _goal.IsAchieved();
        public bool IsClaimed => _isClaimed;

        public Mission(IAchievable goal, IRewardable reward, Player owner = null)
        {
            _goal = goal;
            _reward = reward;
            goal.OnAchieve += Check;
            _owner = owner;
            if (owner != null)
            {
                Accept(owner);
            }
        }
        public float CheckStatus()
        {
            return _goal.CheckStatus();
        }

        public void Claim()
        {
            if (_isAchieved)
            {
                _reward.Reward(_owner);
                _isClaimed = true;
                OnClaim?.Invoke();
            }
        }
        public void Accept(Player by)
        {
            _owner = by;
            _goal.Accept(by);
            _isAccepted = true;
            Register();
        }

        public void Register()
        {
            Clock.Instance.Register(this);
        }

        public void Check()
        {
            if (_isAccepted && !_isAchieved && _goal.IsAchieved())
            {
                _isAchieved = true;
                OnAchievement?.Invoke();
            }
        }

        public void Tick()
        {
            Check();
        }
    }
}