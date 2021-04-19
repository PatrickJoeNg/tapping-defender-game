using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyTile : MonoBehaviour
{
    [SerializeField] float moveSpeed = 2f;

    Rigidbody2D rb;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void FixedUpdate()
    {
        moveDiamond();
    }

    void moveDiamond()
    {
        rb.velocity = -transform.up * moveSpeed * Time.deltaTime;
    }
}
