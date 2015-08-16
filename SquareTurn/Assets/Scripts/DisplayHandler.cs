using UnityEngine;
using System.Collections;

public class DisplayHandler : MonoBehaviour {


	private GameObject portraitCanvas;
	private GameObject landscapeCanvas;

	// Use this for initialization
	void Awake () {
		portraitCanvas = GameObject.Find ("CanvasPortrait");
		landscapeCanvas = GameObject.Find ("CanvasLandscape");
	}

	void Update()
	{
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
