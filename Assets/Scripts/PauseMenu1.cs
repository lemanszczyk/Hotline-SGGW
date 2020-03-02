using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PauseMenu1 : MonoBehaviour
{
    public GameObject pauseMenu;
    public void Quit()
    {
        Debug.Log("Quit");
        Application.Quit();
    }
    public void Resume()
    {
        pauseMenu.SetActive(false);
        Time.timeScale = 1f;
        PauseMenu.GameIsPause = false;
    }
    public void GoToMenu()
    {
        SceneManager.LoadScene("Main menu");
    }
}
