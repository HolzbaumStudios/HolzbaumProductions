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

        #if UNITY_EDITOR
                if (Screen.width > Screen.height)
                {
                    debugSimulateLandscape = true;
                }
                else
                {
                    debugSimulateLandscape = false;
                }

        #endif

        if (Screen.orientation == ScreenOrientation.LandscapeLeft || Screen.orientation == ScreenOrientation.LandscapeRight || debugSimulateLandscape == true)
		{
			SetScreenOrientation(true);
			DisableAutoRotation(true);
		}
		else
		{
			SetScreenOrientation(false);
			DisableAutoRotation(false);
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

	public void DisableAutoRotation(bool setLandscape) {
		if(setLandscape)
		{
			Screen.autorotateToPortrait = false;
			Screen.autorotateToPortraitUpsideDown = false;
			Screen.orientation = ScreenOrientation.Landscape;
		}
		else
		{
			Screen.autorotateToLandscapeLeft= false;
			Screen.autorotateToLandscapeRight= false;
			Screen.orientation = ScreenOrientation.Portrait;
		}
	}

}
