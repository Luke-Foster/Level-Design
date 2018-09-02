using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Counter : MonoBehaviour {

	public float Increment = 0f;  // Starts the counter as 0 
	public Text KeyNumber;

	void Update () {
		KeyNumber.text = "Keys: " + Increment;  // changes the UI element of the key counter to updated version 
	}
}
