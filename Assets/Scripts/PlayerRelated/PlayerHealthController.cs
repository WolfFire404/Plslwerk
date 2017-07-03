using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealthController : MonoBehaviour {

	private float playerHP;

	private bool dead;


	// Use this for initialization
	void Start () {
		playerHP = 10;
		dead = false;
	}
	
	// Update is called once per frame
	void Update () {

		if (playerHP <= 0) {
			dead = true;
		}

		if (!dead) {
			Time.timeScale = 1;
		} else if (dead) {
			Time.timeScale = 0;
			Destroy(this.gameObject);
		}
	}
		void OnTriggerEnter(Collider other){
			if (other.gameObject.CompareTag ("enemy")){
			playerHP = playerHP - 1;
		}
	}
}
