using Lebeg134.Module.Session;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class StartGameScript : MonoBehaviour
{
    public Button newGameBtn;
    // Start is called before the first frame update
    void Start()
    {
        newGameBtn.onClick.AddListener(() => StartGame());
    }

    private void StartGame()
    {
        SceneManager.LoadScene(sceneName: "GameScene");
        Session session = SessionGenerator.GenerateStandard();
        session.Start();
    }

    // Update is called once per frame
    void Update()
    {

    }
}
