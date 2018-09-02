using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Timer : MonoBehaviour {

	public bool Complete = false; // Starts boolean as false 
	public Text CountUp;
	public float Minutes = 0f; // Starts seconds and minutes as 0
	public float Seconds = 0f;
	
	void Update () 
	{
		if (Complete == false) {
			CountUp.text = Minutes + "." + Seconds;

			if (Seconds >= 60f) {  // caps seconds at 60
				Minutes += 1f;
				Seconds = 0f;  // resets seconds to 0 once hitting 60 
			} else {
				Seconds += Time.deltaTime; // time goes up from 0
			}
		}
	}
}
