using System;
using TradeCity.Engine.Session;
using TradeCity.Engine.TimeManager;

namespace TradeCity.Engine.Missions
{
    [Serializable]
    public class Mission : ITickable
    {
        private readonly IAchievable _goal;
        private readonly IRewardable _reward;
        private bool _isAchieved;

        private Player _owner;

        public Mission(IAchievable goal, IRewardable reward, Player owner = null)
        {
            _goal = goal;
            _reward = reward;
            goal.OnAchieve += Check;
            _owner = owner;
            if (owner != null) Accept(owner);
        }
        //Enum state? Strategy?

        public string Text => _goal.Text;
        public bool IsAccepted { get; private set; }

        public bool IsAchieved => _goal.IsAchieved();
        public bool IsClaimed { get; private set; }

        public void Register()
        {
            Clock.Instance.Register(this);
        }

        public void Tick()
        {
            Check();
        }

        public event Action OnProgress;
        public event Action OnAchievement;
        public event Action OnClaim;

        public float CheckStatus()
        {
            return _goal.CheckStatus();
        }

        public void Claim()
        {
            if (!_isAchieved) return;

            _reward.Reward(_owner);
            IsClaimed = true;
            OnClaim?.Invoke();
        }

        public void Accept(Player by)
        {
            _owner = by;
            _goal.Accept(by);
            IsAccepted = true;
            Register();
        }

        private void Check()
        {
            if (!IsAccepted || _isAchieved || !_goal.IsAchieved()) return;

            _isAchieved = true;
            OnAchievement?.Invoke();
        }
    }
}