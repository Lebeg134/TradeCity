using System.Text;
using System.Text.Json;
using UnityEngine;
using UnityEngine.Networking;

namespace TradeCity.Unity.Scripts.Leaderboard
{
    public class WebScorePoster: MonoBehaviour
    {
        private const string Url = "http://localhost:8080";

        private Score SendScore(Score score)
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
    }
}
