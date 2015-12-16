using UnityEngine;
using System.Collections;

public class DisplayHandler : MonoBehaviour {


	public bool debugSimulateLandscape = false; //This variable is only used to simluate the rotation on the pc
	public GameObject portraitCanvas;
	public GameObject landscapeCanvas;
	private bool setToLandscape = false; //Used to check, that functions on screen orientation change only occur once
	private bool setToPortrait = false; //Used to check, that functions on screen orientation change only occur once

	// Use this for initialization
	void Awake () {
		//portraitCanvas = GameObject.Find ("CanvasPortrait");
		//landscapeCanvas = GameObject.Find ("CanvasLandscape");

		SetDisplayMode ();
	}

	void Update()
	{
		SetDisplayMode ();
	}

	void SetDisplayMode()
	{
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

			if(Screen.orientation == ScreenOrientation.LandscapeLeft || Screen.orientation == ScreenOrientation.LandscapeRight || debugSimulateLandscape == true)
			{
				if(!setToLandscape)
				{
				//--What happens before changing
					if(Application.loadedLevelName == "levelMenu")
					{
						SetLevelMenuCategorySlider(false);
					}
					if(Application.loadedLevelName == "startMenu")
					{
						SetLevelMusic(true);
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
					if(Application.loadedLevelName == "startMenu")
					{
						SetLevelMusic(false);
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
		//landscapeCanvas.transform.FindChild("LevelChoice").gameObject.GetComponent<MenuScript> ().SaveCategoryPosition ();
		if(setLandscape)
		{
			levelChoice = landscapeCanvas.transform.FindChild("LevelChoice").gameObject;
		}
		else
		{
			levelChoice = portraitCanvas.transform.FindChild("LevelChoice").gameObject;
		}
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

	void SetLevelMusic(bool setLandscape)
	{
		GameObject musicButton; // Das ist der Music Button
		GameObject musicBackground; // Da hängt der Skript MuiscOnOff dran (inkl. Status des Buttons)
		bool statusMusicButton; // Der aktuelle Status

		musicBackground = GameObject.Find("Music_Background").gameObject;
        if (PlayerPrefs.GetString("gameMusic") != "Off")
        {
            statusMusicButton = true;
        }
        else
        {
            statusMusicButton = false;
        }
		//statusMusicButton = musicBackground.GetComponent<musicOnOff>().status;

		if(setLandscape) 
		{
			Transform imageBackground = landscapeCanvas.transform.FindChild("Image_Background");
			musicButton = imageBackground.FindChild ("SquareImage_Music").gameObject;
		} 
		else
		{
			Transform imageBackground = portraitCanvas.transform.FindChild("Image_Background");
			musicButton = imageBackground.FindChild ("SquareImage_Music").gameObject;
		}
		TurnButton (musicButton, statusMusicButton);
		
	}

	public void TurnButton(GameObject musicButton, bool status)
	{
		GameObject squareMusicButton = musicButton;
		
		if (status == false)
		{
			squareMusicButton.GetComponent<UnityEngine.UI.Image> ().color = new Color32(131, 139, 139, 255);
			squareMusicButton.transform.FindChild ("DisabledButton").gameObject.SetActive (true);
		}
		else if (status == true)
		{
			squareMusicButton.GetComponent<UnityEngine.UI.Image> ().color = new Color32(72, 120, 168, 255);
			squareMusicButton.transform.FindChild ("DisabledButton").gameObject.SetActive (false);
		}
	}



}
