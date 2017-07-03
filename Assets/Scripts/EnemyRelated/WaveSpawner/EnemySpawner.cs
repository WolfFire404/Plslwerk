using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public Transform Spawnpoint;
    public Rigidbody Prefab;

    void OnTriggerEnter(Collider Spawner)
    {
        if (Spawner.tag == "Player")
        {
            Instantiate(Prefab, Spawnpoint.position, Spawnpoint.rotation);
            Instantiate(Prefab, Spawnpoint.position + new Vector3(0.1f,0,0), Spawnpoint.rotation);
            Instantiate(Prefab, Spawnpoint.position + new Vector3(0,0.1f,0), Spawnpoint.rotation);

            var reged = Spawner.GetComponent<Rigidbody>();
            reged.AddExplosionForce(5000, transform.position, 200);

            Destroy(gameObject);
        }
    }
}