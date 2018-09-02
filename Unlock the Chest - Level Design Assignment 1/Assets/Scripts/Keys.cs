using UnityEngine;
using System.Collections;

public class Keys : MonoBehaviour {

	public GameObject Key;   //Key is gameobject
	public GameObject text;
	public GameObject InteractiveAudio;
 

	void OnTriggerEnter () //Trigger has been activated
	{
		InteractiveAudio.GetComponent<AudioSource>().Play();  // plays the audio clip from other gameobject because key gets destroyed
		Counter i = text.GetComponent<Counter> ();    // refers to counter script 
		i.Increment += 1f;                          // increments counter script
 		Destroy (Key);     //key gets destroyed
	}
}

