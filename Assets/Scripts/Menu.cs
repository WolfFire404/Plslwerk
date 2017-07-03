using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Menu : MonoBehaviour {

	[SerializeField]
	private string Destination;


	public void LoadScene () {
		Application.LoadLevel (Destination);
		Debug.Log ("Load");

	}
	public void ClickExit(){
		Application.Quit();
		Debug.Log ("Exit");
	}
}
