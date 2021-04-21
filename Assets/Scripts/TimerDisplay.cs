using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class TimerDisplay : MonoBehaviour
{ 
    [SerializeField] TextMeshProUGUI timerText;
    GameTimer gameTimer;
    

    // Start is called before the first frame update
    void Start()
    {
        timerText = GetComponent<TextMeshProUGUI>();
        gameTimer = FindObjectOfType<GameTimer>();
    }

    // Update is called once per frame
    void Update()
    {
        timerText.text = Mathf.RoundToInt(gameTimer.GetTimeRemaining()).ToString();
    }
}
