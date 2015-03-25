using UnityEngine;
using System.Collections;

public class LoadOnClick : MonoBehaviour {

	public void LoadScene(int scene)
	{
		Application.LoadLevel (scene);
	}

}
