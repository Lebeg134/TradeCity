
using System;

namespace TradeCity.Unity.Scripts.Leaderboard
{
    [Serializable]
    public class Score
    {
        private const string Secret = "SomeUniqueIdentifier";
        public long id;
        public readonly string username;
        public readonly long score;
        public DateTime date;

        public Score(string username, long score)
        {
            this.username = username;
            this.score = score;
        }

        public int GetSecret()
        {
            return Secret.GetHashCode()+username.GetHashCode()+score.GetHashCode();
        }

    }
}
