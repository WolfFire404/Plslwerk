using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Explosion : MonoBehaviour
{
   public Transform biem;

    void Start ()
    {
        biem.GetComponent<ParticleSystem>().Stop();
    }

    void OnTriggerEnter()
    {
        biem.GetComponent<ParticleSystem>().Simulate(0, true, true);
        StartCoroutine(Exploosioon());
    }

    IEnumerator Exploosioon()
    {
        yield return new WaitForSeconds(0.1f);

        biem.GetComponent<ParticleSystem>().Stop();  
    }

}
