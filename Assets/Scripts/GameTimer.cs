using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameTimer : MonoBehaviour
{
    [SerializeField] float timeRemaining = 30f;
    bool timerOn = false;

    void Start()
    {
        timerOn = true;
    }

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
    public float GetTimeRemaining()
    {
        return timeRemaining;
    }
}
