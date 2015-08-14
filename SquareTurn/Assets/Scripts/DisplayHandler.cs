using UnityEngine;
using System.Collections;

public class DisplayHandler : MonoBehaviour {

	// Use this for initialization
	void Awake () {
		GameObject portraitCanvas = GameObject.Find ("StartMenuCanvasPortrait");
		GameObject landscapeCanvas = GameObject.Find ("StartMenuCanvas");

		if(Screen.width < Screen.height)
		{
			portraitCanvas.SetActive(true);
			landscapeCanvas.SetActive(false);
		}else{
			portraitCanvas.SetActive(false);
			landscapeCanvas.SetActive(true);
		}
	}

}
