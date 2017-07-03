using UnityEngine;
using System.Collections;

public class Rotator : MonoBehaviour 
{
	[SerializeField]
	private float rotationSpeed;

	private Vector3 rotateVector;

	void Start()
	{
		//float x = Random.Range (0f, 360f);
		rotateVector = Random.insideUnitSphere; //new Vector3 (15, 30, 45);
		print(rotateVector);

	}

	void Update () 
	{
		transform.Rotate (rotateVector * rotationSpeed * Time.deltaTime);  
	}
}
