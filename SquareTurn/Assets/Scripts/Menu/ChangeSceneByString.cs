using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class ChangeSceneByString : MonoBehaviour {

	// This script is used to change the scene depending on the String.
	// The script shouldn't contain actions depending on a specific scene

	public void LoadSceneByString(string sceneName)
	{
        SceneManager.LoadScene(sceneName);
	}
}
