using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    public float speed = 3f;
    public Rigidbody2D rb;
    void Start()
    {
        initializeBallVelocity();
    }

    void initializeBallVelocity()
    {
        float x = Random.Range(0, 2) == 0 ? -1 : 1;
        float y = Random.Range(0, 2) == 0 ? -1 : 1;
        rb.velocity = new Vector2(x*speed, y*speed);
    }

   
    void Update()
    {
        
    }
}
