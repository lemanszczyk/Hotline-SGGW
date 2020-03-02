using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void playButton()
    {
        Time.timeScale = 1;
        PauseMenu.GameIsPause = false;

        SceneManager.LoadScene("Level1");    
    }
    public void quitButton()
    {
        Application.Quit();
    }
}
