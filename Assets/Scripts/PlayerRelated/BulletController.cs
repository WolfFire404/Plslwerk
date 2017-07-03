using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletController: MonoBehaviour {

	public float speed;
	public float lifetime = 2.0f;




	void  Awake ()
	{
		Destroy(gameObject, lifetime);
	}

	void Update(){

		transform.Translate (Vector3.forward * speed * Time.deltaTime);
	}

	void OnTriggerEnter(Collider other) 
	{
		if (other.gameObject.CompareTag ("wall")){
			Destroy (gameObject);
		}

		if (other.gameObject.CompareTag ("enemy")){
			Destroy (gameObject);
		}
	}

}
