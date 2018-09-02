using UnityEngine;
using System.Collections;

public class Drown : MonoBehaviour {

	public GameObject Spawn;
	public float Delay = 6f;    // 6 second delay before death 
	public float Bubble = 6f;   
	public GameObject DrownCounter1;
	public GameObject DrownCounter2;  // bubble image gameobjects 
	public GameObject DrownCounter3;
	public GameObject DrownCounter4;
	public GameObject DrownCounter5;
	
	void Update () {
		
		if (transform.position.y <= 1.25) {  // if below water level
			
			DrownCounter1.SetActive (true);
			DrownCounter2.SetActive (true);
			DrownCounter3.SetActive (true);  // makes bubble images visible 
			DrownCounter4.SetActive (true);
			DrownCounter5.SetActive (true);


			Delay -= Time.deltaTime;
			if (Delay < 1) {    // as soon as timer becomes less than 1 
				transform.position = Spawn.transform.position;   // returns player to spawn 
			}
			Bubble -= Time.deltaTime;
			if (Bubble < 5)
			{
				DrownCounter1.SetActive (false);   // each of these steps makes bubble image invisible after ever 1 second 
			}
			if (Bubble < 4)
			{
				DrownCounter2.SetActive (false);
			}
			if (Bubble < 3)
			{
				DrownCounter3.SetActive (false);
			}
			if (Bubble < 2)
			{
				DrownCounter4.SetActive (false);
			}
			if (Bubble < 1)
			{
				DrownCounter5.SetActive (false);
			}
		}
		else 
		{
			Delay = 6f;
			Bubble = 6f;
			DrownCounter1.SetActive (false);  // returns bubble images back to hidden when exiting water 
			DrownCounter2.SetActive (false);
			DrownCounter3.SetActive (false);
			DrownCounter4.SetActive (false);
			DrownCounter5.SetActive (false);

		}
	}
}
