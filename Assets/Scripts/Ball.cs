using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    public float speed = 3f;
    public Rigidbody2D rb;
    Vector3 startPosition;
    void Start()
    {
        startPosition = transform.position;
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
        Vector3 viewPos = UnityEngine.Camera.main.WorldToViewportPoint(transform.position);
        bool isVisible = true;
        if (viewPos.x >= 0 && viewPos.x <= 1 && viewPos.y >= 0 && viewPos.y <= 1 && viewPos.z > 0)
        {
            isVisible = true;
        }
        else
        {
            isVisible = false;
        }

        if (!isVisible)
        {
            Debug.Log("you have lost");
            transform.position = startPosition;
            initializeBallVelocity();
        }
    }
}
