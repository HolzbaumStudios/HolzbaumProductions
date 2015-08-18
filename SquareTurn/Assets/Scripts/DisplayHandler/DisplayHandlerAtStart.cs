using UnityEngine;
using System.Collections;

public class DisplayHandlerAtStart : MonoBehaviour {


	public bool debugSimulateLandscape = false; //This variable is only used to simluate the rotation on the pc
	private GameObject portraitCanvas;
	private GameObject landscapeCanvas;


	// Use this for initialization
	void Awake () {
		portraitCanvas = GameObject.Find ("CanvasPortrait");
		landscapeCanvas = GameObject.Find ("CanvasLandscape");

		if(Screen.orientation == ScreenOrientation.Landscape || debugSimulateLandscape == true)
		{
			SetScreenOrientation(true);
		}
		else
		{
			SetScreenOrientation(false);
		}

	}
	

	//Enable/disable the canvas based on the screen orientation
	void SetScreenOrientation(bool setLandscape)
	{
		if(setLandscape)
		{
			portraitCanvas.SetActive(false);
			landscapeCanvas.SetActive(true);
		}
		else
		{
			portraitCanvas.SetActive(true);
			landscapeCanvas.SetActive(false);
		}
	}

}
