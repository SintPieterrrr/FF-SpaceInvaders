using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public GameObject Enemy;

    void Awake()
    {
        for (int i = 0; i < 4; i++)
        {
            Instantiate(Enemy, transform.position + 1.5f * Vector3.right * i, Quaternion.identity);
        }        
    }
}
