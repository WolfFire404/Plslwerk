using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUpPS : MonoBehaviour { //PICKUP PLAYER SIDE
		
	private Rigidbody rb;
	public GunController _gc;
	public GameObject Gun;

		
	void Start (){
		rb = GetComponent<Rigidbody>();
	}

	void OnTriggerEnter(Collider other){
		if (this.gameObject.tag == "Player") {
			GunController _gc = Gun.GetComponent<GunController> ();
			PlayerMovement _pm = this.GetComponent<PlayerMovement> ();

				//MOVEMENT +SPEED POWERUP

			if (other.gameObject.tag == "SpeedUp"){
					_pm.moveSpeed += 0.5f;
					Destroy (other.gameObject);
				}

				//MOVEMENT -SPEED POWERUP
				if (other.gameObject.tag == "SpeedDown") {
					_pm.moveSpeed -= 0.5f;
					Destroy (other.gameObject);
				}

				//FIRE +RATE POWERUP

				if (other.gameObject.tag == "FireRateUp" ) {
					_gc.bulletCD -= 0.05f;
					Destroy (other.gameObject);
				}

				//FIRE -RATE POWERUP
				if (other.gameObject.tag == "FireRateDown") {
					_gc.bulletCD += 0.05f;
					Destroy (other.gameObject);
			}
		}
	}
}
