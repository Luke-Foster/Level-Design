using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class EndGame : MonoBehaviour {
	
	public Button retryText;   // declaring the two end menu button variables
	public Button exitText;
	public GameObject textQuestion;
	public GameObject textRetry;
	public GameObject textQuit;  // declaring gameobjects from the hierarchy that need to be hidden
	public GameObject Spawn;
	public GameObject Character;
	public GameObject Timer;
	public GameObject KeyCounter;
	public GameObject MainCamera;
	public GameObject text;
	public GameObject numbers;
	public GameObject Sign;
	public GameObject Location;

	void Start () 
	{
		retryText = retryText.GetComponent<Button> ();   //finding the ui buttons so this script can be applied to them
		exitText = exitText.GetComponent<Button> ();    // also means the fuction can be initiated
	}
	
	void OnTriggerEnter ()
	{
		Counter i = text.GetComponent<Counter> ();    // refering to another script which holds counter
		if (i.Increment == 4f)                        // only executes if 4 keys are on counter
		{
			GetComponent<AudioSource>().Play();     // activating chest sound
			GetComponent<Animation>().Play ();         // activating chest animation
			Timer x = numbers.GetComponent<Timer> ();   // refering to timer script 
			x.Complete = true;                           // stops the timer from continuing counting up
			Timer.transform.position = Location.transform.position;   //moving timer position to centre of end menu
			Timer.transform.position = Location.transform.position;
			Character.transform.position = Spawn.transform.position;  // moves player back to spawn
			Character.SetActive (false);   // making player unable to move or see character 
			MainCamera.SetActive (true);   // making the end menu visible and interactable 
			textQuestion.SetActive (true);
			textRetry.SetActive (true);
			textQuit.SetActive (true);
			KeyCounter.SetActive (false);   // hiding unecessary UI element now
			Sign.SetActive (false);
		}
	}
	public void Restart()
	{
		Application.LoadLevel ("Island");   // restarts level by loading the same scene again
	}
	public void Quit()
	{
		Application.LoadLevel ("StartMenu");   // Send user back to start menu
	}

}
