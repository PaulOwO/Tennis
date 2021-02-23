using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    private float x;
    private float y;
    [SerializeField] AudioSource audioSource;
    public float speed = 3f;
    public Rigidbody2D rb;
    Vector3 startPosition;
    void Start()
    {
        startPosition = transform.position;
        Launch();
    }

    private void Launch()
    {
        if (Random.Range(0, 2) == 0)
        {
            x = -1;
        }
        else
        {
            x = 1;
        }
        if (Random.Range(0, 2) == 0)
        {
            y = -1;
        }
        else
        {
            y = 1;
        }
    }


    void Update()
    {
        rb.velocity = new Vector2 (speed, speed);
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
            Launch();
            //timerGoing = false;
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.layer == LayerMask.NameToLayer("Wall"))
        {
            speed = speed + 0.25f;
            audioSource.Play();
        }
    }
}
