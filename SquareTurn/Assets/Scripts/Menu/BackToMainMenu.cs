using UnityEngine;
using System.Collections;

public class BackToMainMenu : MonoBehaviour {
	//THis script is used to access the main menu
	
	public void BackToMenu(){
		Application.LoadLevel ("startMenu");
	}
}
