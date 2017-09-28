using UnityEngine;
using UnityEngine.SceneManagement;

public class GameSceneManager : MonoBehaviour
{
    public void OnStartButtonClick()
    {
        SceneManager.LoadScene("Main");
    }

    public void OnQuitButtonClick()
    {
        Application.Quit();
    }
}
