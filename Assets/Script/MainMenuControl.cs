using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuControl : MonoBehaviour
{
    public void PlayGame()
    {
        SceneManager.LoadScene("Gameplay", LoadSceneMode.Single);
    }

    public void HowToPlay()
    {
        SceneManager.LoadScene("HowToPlay", LoadSceneMode.Single);
    }

    public void BackMainMenu()
    {
        SceneManager.LoadScene("Main Menu", LoadSceneMode.Single);
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}
