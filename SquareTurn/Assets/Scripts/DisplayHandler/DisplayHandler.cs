using UnityEngine;
using System.Collections;

public class DisplayHandler : MonoBehaviour {


	public bool debugSimulateLandscape = false; //This variable is only used to simluate the rotation on the pc
	private GameObject portraitCanvas;
	private GameObject landscapeCanvas;
	private bool setToLandscape = false; //Used to check, that functions on screen orientation change only occur once
	private bool setToPortrait = false; //Used to check, that functions on screen orientation change only occur once

	// Use this for initialization
	void Awake () {
		portraitCanvas = GameObject.Find ("CanvasPortrait");
		landscapeCanvas = GameObject.Find ("CanvasLandscape");

		landscapeCanvas.SetActive (false);
	}

	void Update()
	{	
			

			if(Screen.orientation == ScreenOrientation.Landscape || debugSimulateLandscape == true)
			{
				if(!setToLandscape)
				{
				//--What happens before changing
					if(Application.loadedLevelName == "levelMenu")
					{
						SetLevelMenuCategorySlider(false);
					}

					SetScreenOrientation(true);

				//--What happens after changing
					//Only on levelMenu -- Set correct category
					if(Application.loadedLevelName == "levelMenu")
					{
						SetLevelMenu(true);
					}

					setToLandscape = true;
					setToPortrait = false;
				}
			}
			else
			{
				if(!setToPortrait)
				{
				//--What happens before changing
					if(Application.loadedLevelName == "levelMenu")
					{
						SetLevelMenuCategorySlider(true);
					}


					SetScreenOrientation(false);

				//--What happens after changing
					//Only on levelMenu -- Set correct category
					if(Application.loadedLevelName == "levelMenu")
					{
						SetLevelMenu(false);
					}


					setToLandscape = false;
					setToPortrait = true;
				}
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

	void SetLevelMenuCategorySlider(bool setLandscape)
	{
		GameObject levelChoice;
		if(setLandscape)
		{
			levelChoice = landscapeCanvas.transform.FindChild("LevelChoice").gameObject;
		}
		else
		{
			levelChoice = portraitCanvas.transform.FindChild("LevelChoice").gameObject;
		}
		levelChoice.GetComponent<MenuScript> ().SaveCategoryPosition ();
	}

	//Set the settings for the levelMenu
	void SetLevelMenu(bool setLandscape)
	{
		int activeCategory = PlayerPrefs.GetInt ("ActiveCategory");
		GameObject levelChoice;
		if(setLandscape)
		{
			levelChoice = landscapeCanvas.transform.FindChild("LevelChoice").gameObject;
		}
		else
		{
			levelChoice = portraitCanvas.transform.FindChild("LevelChoice").gameObject;
		}

		if (activeCategory > 0)
		{
			levelChoice.GetComponent<MenuScript>().ChooseCategory (activeCategory);
			levelChoice.GetComponent<MenuScript> ().SetSliderPosition ();
		}
		else
		{
			//Disable the active Category
			levelChoice.GetComponent<MenuScript>().DisableAllCategories();
		}
	}


}
