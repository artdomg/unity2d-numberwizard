using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    public void LoadCoreGameScene()
    {
        SceneManager.LoadScene("Core Game");
    }

    public void LoadStartScene()
    {
        SceneManager.LoadScene("Start Menu");
    }

    public void LoadWinScreen()
    {
        SceneManager.LoadScene("Win Screen");
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}
