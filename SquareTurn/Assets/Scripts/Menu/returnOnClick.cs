using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class returnOnClick : MonoBehaviour {

	// Functions
	public void returnToMenu(){
        SceneManager.LoadScene("startMenu");
	}
}
