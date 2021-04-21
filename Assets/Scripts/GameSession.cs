using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameSession : MonoBehaviour
{
    [SerializeField] int score = 0;
    [SerializeField] float timeRemaining = 99f;

    bool timerOn = true;

    void Awake()
    {
        SetUpSingleton();
    }

    private void SetUpSingleton()
    {
        int numOfGameSessions = FindObjectsOfType<GameSession>().Length;

        if (numOfGameSessions > 1)
        {
            Destroy(gameObject);
        }else
        {
            DontDestroyOnLoad(gameObject);
        }
    }

    void Start()
    {
        // init timer
        timerOn = true;
    }
    // Update is called once per frame
    void Update()
    {
        TimerStatus();
    }

    private void TimerStatus()
    {
        if (timerOn)
        {
            timeCountdown();
        }
    }
    public void timeCountdown()
    {
        if (timeRemaining > 0)
        {
            timeRemaining -= Time.deltaTime;
        }
        if (timeRemaining <= 0)
        {
            timeRemaining = 0;
            Debug.Log("Time Out!");
            timerOn = false;
            FindObjectOfType<LevelManager>().GameOver();
        }
    }

    public int GetScore()
    {
        return score;
    }
    public void AddScore(int amount)
    {
        score += amount;
    }
    public void SubtractScore(int amount)
    {
        score -= amount;
        GetScore();
    }

    public float GetTimeRemaining()
    {
        return timeRemaining;
    }

    public void ResetGame()
    {
        Destroy(gameObject);
    }
}
