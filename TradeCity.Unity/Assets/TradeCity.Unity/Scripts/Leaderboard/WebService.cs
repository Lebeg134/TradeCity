using System.Collections.Generic;
using System.Text;
using System.Text.Json;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.Networking;

namespace TradeCity.Unity.Scripts.Leaderboard
{
    public class WebService: MonoBehaviour
    {
        private const string Url = "http://localhost:8080";

        public Score PostScore(Score score)
        {
            WWWForm form = new WWWForm();
            form.AddField("key", score.GetSecret());
            string jsonString = JsonSerializer.Serialize(score);
            using (UnityWebRequest request = UnityWebRequest.PostWwwForm(Url, jsonString))
            {
                request.SendWebRequest();

                if (request.error != null)
                {
                    //TODO
                }
            }
            return score;
        }

        public List<Score> GetScores()
        {
            return new List<Score>();
        }
    }
}
