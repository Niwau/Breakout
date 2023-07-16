using System.Collections;
using System.Collections.Generic;
using UnityEditor.Experimental.GraphView;
using UnityEngine;

public class Ball : MonoBehaviour
{
    public float speed = 0.1f;
    private Vector2 direction = new Vector2(1,-1);
    private Rigidbody2D rb;
    private TrailRenderer trail;
    private AudioSource audioSource;
    void Start() {
        trail = GetComponent<TrailRenderer>();
        rb = GetComponent<Rigidbody2D>();
        audioSource = GetComponent<AudioSource>();
        rb.AddForce(direction * speed);
    }

    void OnCollisionEnter2D(Collision2D other) {
        if (other.gameObject.CompareTag("block"))
        {
            audioSource.Play();
            Color blockColor = other.gameObject.GetComponent<SpriteRenderer>().color;
            trail.startColor = blockColor;
            this.gameObject.GetComponent<SpriteRenderer>().color = blockColor;
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
