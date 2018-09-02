using UnityEngine;
using System.Collections;

public class TextScript : MonoBehaviour {
	public GameObject Message;

	void OnTriggerEnter () { // when trigger box collider has been entered 

		Message.SetActive (true);  // makes text on sign visible 

	}
	void OnTriggerExit() {  // when trigger box collider has been exited 
	
		Message.SetActive (false);   // makes text on sign hidden  

	}
}
