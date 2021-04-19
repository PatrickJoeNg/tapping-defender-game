using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameSession : MonoBehaviour
{
    [SerializeField] int score = 0;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

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
}
