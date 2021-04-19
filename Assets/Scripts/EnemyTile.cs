using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyTile : MonoBehaviour
{
    [SerializeField] int scoreValue = 50;
    [SerializeField] float moveSpeed = 2f;

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
            Debug.Log("Diamond clicked");
            Destroy(gameObject);
            SubFromScore(scoreValue);
        }
    }

    private void FixedUpdate()
    {
        moveDiamond();
    }

    void moveDiamond()
    {
        rb.velocity = -transform.up * moveSpeed * Time.deltaTime;
    }
    void SubFromScore(int score)
    {
        FindObjectOfType<GameSession>().SubtractScore(score);
    }
}
