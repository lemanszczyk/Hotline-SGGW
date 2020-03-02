using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PauseMenu : MonoBehaviour
{
    public static bool GameIsPause = false;
    public GameObject pauseMenuUI;
    void Start()
    {
        pauseMenuUI.SetActive(false);
    }
    // Update is called once per frame
    void Update()
    {
    if (Input.GetKeyDown(KeyCode.Escape))
    {
        if (GameIsPause)
        {
           Resume();
        }
        else
        {
           Pause();
        }
    }
    }
    void Resume()
    {
        pauseMenuUI.SetActive(false);
        Time.timeScale = 1f;
        GameIsPause = false;
    }
    void Pause()
    {
        pauseMenuUI.SetActive(true);
        Time.timeScale = 0f;
        GameIsPause = true;
    }
}
