using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class MasterKey : MonoBehaviour {

	public GameObject Key;   //Key is gameobject
	public GameObject text;
	public GameObject InteractiveAudio;

	void OnTriggerEnter () //Trigger has been activated
	{
		InteractiveAudio.GetComponent<AudioSource>().Play();   // plays audio source 
		Counter i = text.GetComponent<Counter> ();  // refers to counter script 
		i.Increment = 4f;     // instanstly makes key counter 4 
		Destroy (Key);     //key gets destroyed
	}
}
