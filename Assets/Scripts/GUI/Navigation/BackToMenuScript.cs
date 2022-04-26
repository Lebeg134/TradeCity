using Lebeg134.Module.Session;
using Lebeg134.Module.TimeManager;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class BackToMenuScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        GetComponent<Button>().onClick.AddListener(() =>
        {
            Clock.Instance.Pause();
            Session.Save();
            SceneManager.LoadScene(sceneName: "MainMenu");
        });
    }
    // Update is called once per frame
    void Update()
    {

    }
}
