using System;
using System.Collections.Generic;
using System.Text.Json;
using UnityEngine;
using UnityEngine.Networking;
using SimpleJSON;
using System.Collections;
using NUnit.Framework;

namespace TradeCity.Unity.Scripts.Leaderboard
{
    public class WebService: MonoBehaviour
    {
        private const string Url = "http://localhost:8080";

        public Score PostScore(Score score)
        {
            var form = new WWWForm();
            form.AddField("key", score.GetSecret());
            var jsonString = JsonSerializer.Serialize(score);
            using var request = UnityWebRequest.PostWwwForm(Url, jsonString);
            request.SendWebRequest();

            if (request.error != null)
            {
                //TODO
            }

            return score;
        }

        public IEnumerator GetScores(Action<List<Score>> callback, Action error)
        {
            var items = new List<Score>();
            using (var webRequest = UnityWebRequest.Get(Url + "/leaderboard"))
            {
                yield return webRequest.SendWebRequest();
                
                if (webRequest.error != null)
                {
                    error();
                }
                else
                {
                    var jsonResponse = JSON.Parse(webRequest.downloadHandler.text);

                    foreach (JSONNode node in  jsonResponse)
                    {
                        items.Add(new Score(node["username"], node["score"]));
                    }

                }
            }
            callback(items);
        }
    }
}
