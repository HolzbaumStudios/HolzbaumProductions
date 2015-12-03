using UnityEngine;
using System.Collections;

public class EscapeScene : MonoBehaviour {

	public string scene;
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown(KeyCode.Escape))
		{
			Application.LoadLevel(scene);
		}
	}
}
