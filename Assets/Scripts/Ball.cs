using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    public Rigidbody2D rb;
    public bool inPlay;
    public Transform paddle;
    public float speed;

    void Start()
    {
        print("Hello");
        rb = GetComponent<Rigidbody2D>();
        rb.AddForce (Vector2.up * 500);
    }

    void Update()
    {
        if (!inPlay)
        {
            transform.position = paddle.position;
        }
        if (Input.GetButtonDown ("Jump"))
        {
            print("Hello");
            inPlay = true;
            rb.AddForce(Vector2.up * speed);
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag ("bottom"))
        {
            rb.velocity = Vector2.zero;
            inPlay = false;
        }
    }
    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.transform.CompareTag("Brick"))
        {
            Destroy(other.gameObject);
        }
    }
}
