using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class EscapeScene : MonoBehaviour {

	public string scene;
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown(KeyCode.Escape))
		{
            ChangeScene();
		}
	}

    public void ChangeScene()
    {
        if (SceneManager.GetActiveScene().name == "startMenu")
        {
            Debug.Log("Quit Application!");
            Application.Quit();
        }
        else
        {
            SceneManager.LoadScene(scene);
        }
    }
}
