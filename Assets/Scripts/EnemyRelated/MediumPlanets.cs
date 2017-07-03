using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MediumPlanets : MonoBehaviour
{

    PlayerController player;
    public Transform Spawnpoint;
    public Rigidbody Prefab;

    private void Start()
    {
        var playerobj = GameObject.FindGameObjectWithTag("Player");
        if (playerobj)
        player = playerobj.GetComponent<PlayerController>();
    }

    void OnTriggerEnter(Collider Spawner)
    {
        if (Spawner.tag == "Player")
        {
            if (player.counter <= 10)
            {
                Destroy(Spawner.gameObject);
                StartCoroutine(LoseScreen());
            }
            else
            {
                Instantiate(Prefab, Spawnpoint.position, Spawnpoint.rotation);
                Instantiate(Prefab, Spawnpoint.position + new Vector3(0.1f, 0, 0), Spawnpoint.rotation);
                Instantiate(Prefab, Spawnpoint.position + new Vector3(0, 0.1f, 0), Spawnpoint.rotation);

                var reged = Spawner.GetComponent<Rigidbody>();
                reged.AddExplosionForce(5000, transform.position, 200);

                Destroy(gameObject);
            }
        }
    }

    IEnumerator LoseScreen()
    {
        yield return new WaitForSeconds(2.0f);
        SceneManager.LoadScene("loseScene");
    }

}
