using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Moves and rotates player
/// </summary>

public class PlayerMovement : MonoBehaviour {

	public float moveSpeed;
	private Rigidbody myRigidBody;

	private Vector3 moveInput;
	private Vector3 moveVelocity;

	private Camera mainCamera;

	private float FireRate = 0.3f;
	private float NextFire;

	public bool useController;

    Vector3 position;

	void Start(){

		myRigidBody = GetComponent<Rigidbody>();
		mainCamera = FindObjectOfType<Camera> ();
        position = transform.position;
	}

	void Update(){
		if(!useController){
			moveInput = new Vector3(Input.GetAxisRaw("Horizontal"), 0f, Input.GetAxisRaw("Vertical"));
			moveVelocity = moveInput * moveSpeed;


			//Rotate with mouse
//
//			Ray cameraRay = mainCamera.ScreenPointToRay(Input.mousePosition);
//			Plane groundPlane = new Plane (Vector3.up, Vector3.zero);
//			float rayLength;
//
//			if(groundPlane.Raycast(cameraRay, out rayLength)){
//
//				Vector3 pointToLook = cameraRay.GetPoint(rayLength);
// 
//				transform.LookAt(new Vector3(pointToLook.x, transform.position.y, pointToLook.z));
//			}
		}

		//ROTATE WITH CONTROLLER
		if (useController) {

			Vector3 playerDirection = Vector3.right * Input.GetAxisRaw ("RHorizontal") + 
			Vector3.forward * -Input.GetAxisRaw ("RVertical");


			if (playerDirection.sqrMagnitude > 0.0f) {

				transform.rotation = Quaternion.LookRotation (playerDirection, Vector3.up);
			}
		}
	}

	void FixedUpdate(){
		myRigidBody.velocity += moveVelocity * Time.deltaTime;
        myRigidBody.velocity = Vector3.zero;
	}
}
