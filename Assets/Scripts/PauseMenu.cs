using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    public static bool gameIsPaused = false;
    public GameObject pauseMenuUI;
    // Update is called once per frame
    void Update()
    {
        
    }
    public void PausePressed()
    {
        if (gameIsPaused)
        {
            Resume();
        }
        else
        {
            Pause();
        }
        
    }
    public void Resume()
    {
        pauseMenuUI.SetActive(false);
        Time.timeScale = 1f;
    }
    void Pause()
    {
        pauseMenuUI.SetActive(true);
        Time.timeScale = 0f;
    }
    public void LoadMainMenu()
    {
        SceneManager.LoadScene("StartScreen");
        Time.timeScale = 1f;
    }
}