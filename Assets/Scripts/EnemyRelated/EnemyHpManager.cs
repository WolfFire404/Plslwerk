using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHpManager : MonoBehaviour {

	private float enemyStartHP = 6;
	private float enemyCurrentHP;

	// Use this for initialization
	void Start () {
	
		enemyCurrentHP = enemyStartHP;
	}
		
	// Update is called once per frame
	void Update () {

		if (enemyCurrentHP <= 0){
			Destroy (gameObject);
		}
	}

	void OnTriggerEnter(Collider other){
		if (other.gameObject.CompareTag ("bullet")){
			enemyCurrentHP = enemyCurrentHP - 1;
		}
	}

}
