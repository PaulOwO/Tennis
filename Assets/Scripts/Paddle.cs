using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paddle : MonoBehaviour
{

    public bool isPlayer;

    public float speed;

    public Rigidbody2D rb;

    private float movement;
    
    void Start()
    {
        
    }

    void Update()
    {
        if (isPlayer)
        {
            movement = Input.GetAxisRaw("Paddle");
        }

        rb.velocity = new Vector2(rb.velocity.x, movement * speed);
    }
}
