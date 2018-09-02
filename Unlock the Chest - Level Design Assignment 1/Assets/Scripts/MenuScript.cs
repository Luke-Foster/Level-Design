using UnityEngine;
using UnityEngine.UI;  // Allows access to more parameters from UI 
using System.Collections;

public class MenuScript : MonoBehaviour {

	public Canvas QuitMenu;    
	public Button startText;   // declaring the two start menu button variables
	public Button exitText;

	void Start () 
	{
		QuitMenu = QuitMenu.GetComponent<Canvas> ();
		startText = startText.GetComponent<Button> ();  // gets these components from within the parent where the script is held
		exitText = exitText.GetComponent<Button> ();
		QuitMenu.enabled = false;
	}


	public void ExitPress()    // takes user to quit menu 
	{
		QuitMenu.enabled = true; 
		startText.enabled = false;  
		exitText.enabled = false;
	}

	public void NoPress()   // takes the user from quit menu back to start menu 
	{
		QuitMenu.enabled = false;
		startText.enabled = true;
		exitText.enabled = true;
	}

	public void StartLevel()   // plays the level  
	{
		Application.LoadLevel ("Island");
	} 
	public void ExitGame()   // quits the game 
	{
		Application.Quit ();
	}
}
