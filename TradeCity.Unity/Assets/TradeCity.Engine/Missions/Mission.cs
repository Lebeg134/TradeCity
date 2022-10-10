using System;
using AutSoft.UnitySupplements.EventBus;
using Injecter;
using TradeCity.Engine.Core;
using TradeCity.Engine.Session;
using TradeCity.Engine.TimeManager;

namespace TradeCity.Engine.Missions
{
    [Serializable]
    public class Mission : ITickable
    {
        [NonSerialized]
        [Inject] protected readonly IEventBus _eventBus;

        private readonly IAchievable _goal;
        private readonly IRewardable _reward;
        private bool _isAchieved;

        private Player _owner;

        public Mission(IAchievable goal, IRewardable reward, Player owner = null)
        {
            _eventBus = EngineCore.Instance.InjectEventBus();
            _goal = goal;
            _reward = reward;
            goal.OnAchieve += Check;
            _owner = owner;
            if (owner != null) Accept(owner);
        }

        ~Mission()
        {
            EngineCore.Instance.RemoveTickable(this);
        }

        public string Text => _goal.Text;
        public bool IsAccepted { get; private set; }

        public bool IsAchieved => _goal.IsAchieved();
        public bool IsClaimed { get; private set; }

        public void Register()
        {
            EngineCore.Instance.RegisterTickable(this);
        }

        public void Tick()
        {
            Check();
        }
        
        public float CheckStatus()
        {
            return _goal.CheckStatus();
        }

        public void Claim()
        {
            if (!_isAchieved) return;

            _reward.Reward(_owner);
            IsClaimed = true;
            _eventBus.Invoke(new MissionRewardClaimed(_owner, this));
        }

        public void Accept(Player by)
        {
            _owner = by;
            _goal.Accept(by);
            IsAccepted = true;
            Register();
            _eventBus.Invoke(new MissionAccepted(_owner, this));
        }

        private void Check()
        {
            if (!IsAccepted || _isAchieved || !_goal.IsAchieved()) return;

            _isAchieved = true;
            _eventBus.Invoke(new MissionFinished(this));
        }

        public sealed class MissionAccepted : IEvent
        {
            public MissionAccepted(Player ownerPlayer, Mission acceptedMission)
            {
                OwnerPlayer = ownerPlayer;
                AcceptedMission = acceptedMission;
            }

            public Player OwnerPlayer { get; }
            public Mission AcceptedMission { get; }
        }

        public sealed class MissionFinished : IEvent
        {
            public MissionFinished(Mission finishedMission)
            {
                FinishedMission = finishedMission;
            }

            public Mission FinishedMission { get; }
        }

        public sealed class MissionProgress : IEvent
        {
            public MissionProgress(Mission progressedMission)
            {
                ProgressedMission = progressedMission;
            }

            public Mission ProgressedMission { get; }
        }

        public sealed class MissionRewardClaimed : IEvent
        {
            public MissionRewardClaimed(Player acceptedByPlayer, Mission claimedMission)
            {
                AcceptedByPlayer = acceptedByPlayer;
                ClaimedMission = claimedMission;
            }
            public Player AcceptedByPlayer { get; }
            public Mission ClaimedMission { get; }
        }
    }
}