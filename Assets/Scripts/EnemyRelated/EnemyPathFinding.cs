using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyPathFinding : MonoBehaviour {

	private NavMeshAgent agent;
	private GameObject thePlayer;

	private Rigidbody myRB;


	void Start (){  
		
		agent = GetComponent<NavMeshAgent>();  
		myRB = GetComponent<Rigidbody>();
		thePlayer = GameObject.Find ("Player");

	}

	void Update(){

		agent.destination = thePlayer.transform.position;

	}

	void OnTriggerEnter(Collider other){
		if (other.gameObject.CompareTag ("Player")) {
			myRB.velocity = -transform.forward * 2;
		}
	}
}

