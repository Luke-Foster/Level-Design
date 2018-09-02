using UnityEngine;
using System.Collections;

public class RegionalAudio : MonoBehaviour {

	public GameObject Character;
	public GameObject Regional;

	void OnTriggerEnter () // once box collider is triggered 
	{
		Character.GetComponent<AudioSource> ().Pause (); // pauses constant background music 
		Regional.GetComponent<AudioSource> ().Play ();  // plays new sound clip 
	}
	void OnTriggerExit ()  // once leaving box collider 
	{
		Character.GetComponent<AudioSource> ().UnPause ();  // resumes constant background music 
		Regional.GetComponent<AudioSource> ().Stop ();    // stops new sound clip 
	}
}
