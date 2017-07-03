using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Sun : MonoBehaviour {

    // Use this for initialization
    void OnCollisionEnter(Collision hit)
    {
        if (hit.gameObject.tag == "Player")
        {
            Destroy(hit.gameObject);
            StartCoroutine(LoseScreen());
        }
    }

    IEnumerator LoseScreen()
    { 
            yield return new WaitForSeconds(2.0f);
            SceneManager.LoadScene("loseScene");
    }
}
