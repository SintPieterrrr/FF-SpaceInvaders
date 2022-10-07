using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public GameObject Enemy;

    void Awake()
    {
        Instantiate(Enemy, transform.position, Quaternion.identity);     
    }
}
