using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour
{
    public void LoadGame()
    {
        SceneManager.LoadScene("Game");
        FindObjectOfType<GameSession>().ResetGame();   
    }

    public void MainMenu()
    {
        SceneManager.LoadScene("StartScreen");
    }
    public void GameOver()
    {
        SceneManager.LoadScene("Game Over");
    }
    public void ExitGame()
    {
        Application.Quit();
    }
}
