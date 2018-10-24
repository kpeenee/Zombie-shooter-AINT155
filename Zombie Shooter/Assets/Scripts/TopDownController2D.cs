using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TopDownController2D : MonoBehaviour
{
    public float speed = 5.0f;
    Rigidbody2D rb;

    // Use this for initialization
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }


    void FixedUpdate()
    {
        float x = Input.GetAxis("Horizontal");
        float y = Input.GetAxis("Vertical");


        rb.velocity = new Vector2(x, y) * speed;
        rb.angularVelocity = 0.0f;
    }
}

       
    
