using System.Collections;
using System.Collections.Generic;
using UnityEditor.Experimental.GraphView;
using UnityEngine;

public class Ball : MonoBehaviour
{
    public float speed = 0.1f;
    private Vector2 direction = new Vector2(1,-1);
    private Rigidbody2D rb;

    void Start() {
        rb = GetComponent<Rigidbody2D>();
        rb.AddForce(direction * speed);
    }

    void OnCollisionEnter2D(Collision2D other) {
        if (other.gameObject.CompareTag("block"))
        {
            Destroy(other.gameObject);
        }
    }

    void OnTriggerEnter2D(Collider2D other) {
        if (other.gameObject.CompareTag("gameover"))
        {
           Debug.Log("Game Over");
        }
    }
}
