using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SquarePlayer : MonoBehaviour
{
    [SerializeField] int scoreValue = 100;
    [SerializeField] float moveSpeed = 2f;
    [SerializeField] GameObject explosionFX;
    Rigidbody2D rb;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    private void OnMouseDown()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Vector3 mousePos = Input.mousePosition;
            mousePos = Camera.main.ScreenToWorldPoint(mousePos);
            Debug.Log("Square clicked");
            SquareTapped();
            AddToScore(scoreValue);
        }
    }

    private void SquareTapped()
    {

        Destroy(gameObject);
        GameObject explosion = Instantiate(explosionFX, transform.position, transform.rotation) as GameObject;
    }

    private void FixedUpdate()
    {
        moveSquare();
    }
    void moveSquare()
    {
        rb.velocity = -transform.up * moveSpeed * Time.deltaTime;
    }
    void AddToScore(int score)
    {
        FindObjectOfType<GameSession>().AddScore(score);
    }
}
