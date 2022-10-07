using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float speed;
    public float limit = 8f;
    public GameObject bullet;
    public Transform bulletSpawn;

    // Update is called once per frame
    void Update()
    {
        Move();
        Shoot();

    }

    void Move()
    {
        if (Input.GetKey(KeyCode.RightArrow) && transform.position.x < limit)
        {
            transform.Translate(Vector3.right * speed * Time.deltaTime);
        }
        else if (Input.GetKey(KeyCode.LeftArrow) && transform.position.x > -limit)
        {
            transform.Translate(Vector3.left * speed * Time.deltaTime);
        }
    }

    void Shoot()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(bullet, bulletSpawn.position, Quaternion.identity);
        }
    }
}
