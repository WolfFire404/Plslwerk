using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{

    public float speed = 0;
    private Vector3 direction;

    void Start()
    {
        direction = new Vector3(Random.Range(-1.0f, 1.0f), 0.0f, Random.Range(-1.0f, 1.0f));
    }

    void Update()
    {
        transform.position += direction * speed * Time.deltaTime;
    }
}