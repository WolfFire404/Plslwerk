using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerupController : MonoBehaviour {

//	private GunController _gc;


	//ON PICKUP


//	void OnTriggerEnter(Collider other)
//	{
//		if (other.gameObject.tag == "Player") {
//			GunController _gc = other.GetComponent<GunController> ();
//			PlayerMovement _pm = other.GetComponent<PlayerMovement> ();
//
////MOVEMENT +SPEED POWERUP
//
//			if (this.gameObject.tag == "SpeedUp") {
//				_pm.moveSpeed += 0.5f;
//			}
//
////MOVEMENT -SPEED POWERUP
//			if (this.gameObject.tag == "SpeedDown") {
//				_pm.moveSpeed -= 0.5f;
//			}
//
////FIRE +RATE POWERUP
//
//			if (this.gameObject.tag == "FireRateUp" ) {
//				_gc.bulletCD -= 0.05f;
//			}
//
////FIRE -RATE POWERUP
//			if (this.gameObject.tag == "FireRateDown") {
//				_gc.bulletCD += 0.05f;
//			}
//
//			Destroy (gameObject);
//		}
//	}
}
