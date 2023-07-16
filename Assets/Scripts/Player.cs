using System.Collections;
using System.Collections.Generic;
using UnityEditor.Experimental.GraphView;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float speed = 0.1f;
    private Vector2 direction = Vector2.zero;

    void FixedUpdate()
    {
        transform.Translate(direction * speed);
    }

    void Update() {
        if (Input.GetKey(KeyCode.D)) 
        {
            direction = Vector2.right;
        } else if (Input.GetKey(KeyCode.A))
        {
           direction = Vector2.left;
        } else
        {
            direction = Vector2.zero;
        }
    }
}
