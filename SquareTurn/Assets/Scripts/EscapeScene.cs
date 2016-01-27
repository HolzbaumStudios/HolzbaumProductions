using UnityEngine;
using System.Collections;

public class EscapeScene : MonoBehaviour {

	public string scene;
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown(KeyCode.Escape))
		{
            if(Application.loadedLevelName == "startMenu")
            {
                Debug.Log("Quit Application!");
                Application.Quit();
            }
            else
            {
                Application.LoadLevel(scene);
            }
		}
	}
}
