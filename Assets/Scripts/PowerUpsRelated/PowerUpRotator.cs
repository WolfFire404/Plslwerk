using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUpRotator : MonoBehaviour {

	public Quaternion rotation;

	void Update(){
		transform.Rotate (Vector3.right, 4);
		transform.Rotate (Vector3.down, 4);
	}
}
