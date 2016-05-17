using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class BackToMainMenu : MonoBehaviour {
	//THis script is used to access the main menu
	
	public void BackToMenu(){
        SceneManager.LoadScene("startMenu");
	}
}
