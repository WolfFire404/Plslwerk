using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class TimerUI : MonoBehaviour {


	public float CountdownFrom;

	public Text Timer;


	public float seconds, minutes;

	// Use this for initialization
	void Start () {
		Timer = GetComponent<Text> () as Text;
		CountdownFrom = 300;
	}
	
	// Update is called once per frame
	void Update () {

		float time = CountdownFrom - seconds;

		minutes = (int)(Time.time/60f);
		seconds = (int)(Time.time % 60);
		Timer.text = "Time Left: " + time.ToString("0") + "s";
				
		if(time<=0f) {
			TimeUp();
		}
	}

	void TimeUp() {
		Time.timeScale = 0;
	}
}
