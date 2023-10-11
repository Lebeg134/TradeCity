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

        public IEnumerator GetScores(Action<List<Score>> callback, Action error)
        {
            var items = new List<Score>();
            using (UnityWebRequest webRequest = UnityWebRequest.Get(Url + "/scores"))
            {
                yield return webRequest.SendWebRequest();
                
                if (webRequest.error == null)
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
