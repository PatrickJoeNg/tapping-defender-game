using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class TimerDisplay : MonoBehaviour
{ 
    [SerializeField] TextMeshProUGUI timerText;
    GameSession gameSession;
    

    // Start is called before the first frame update
    void Start()
    {
        timerText = GetComponent<TextMeshProUGUI>();
        gameSession = FindObjectOfType<GameSession>();
    }

    // Update is called once per frame
    void Update()
    {
        timerText.text = Mathf.RoundToInt(gameSession.GetTimeRemaining()).ToString();
    }
}
