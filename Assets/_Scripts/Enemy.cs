using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    Vector3 horizontalStep;
    Vector3 verticalStep;
    public float speed;
    public float horizontalLimit = 8f;

    private void Start()
    {
        horizontalStep = new Vector3(speed, 0f, 0f);
        verticalStep = new Vector3(0f, -1f, 0f);
    }

    void Update()
    {
        Move();
    }

    void Move()
    {
        if (transform.position.x > horizontalLimit || transform.position.x < -horizontalLimit)
        {
            horizontalStep = -horizontalStep;
            transform.Translate(verticalStep);
            transform.position = new Vector3(transform.position.x > 0 ? horizontalLimit : -horizontalLimit, transform.position.y, 0f);
        }

        transform.Translate(horizontalStep * Time.deltaTime);
    }
}
