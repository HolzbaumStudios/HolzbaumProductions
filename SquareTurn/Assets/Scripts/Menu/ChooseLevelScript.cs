using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.Analytics;
using System.Collections.Generic;

public class ChooseLevelScript : MonoBehaviour {
	

	public void LoadLevel(int level){
		//Update Statistics --> Played Levels
		int startedLevels = PlayerPrefs.GetInt ("NumberOfStartedLevels");
		startedLevels++;
		PlayerPrefs.SetInt ("NumberOfStartedLevels", startedLevels);
		
		//Start the Level
		PlayerPrefs.SetInt ("ChosenLevel", level);
		GameObject.Find ("LevelChoice").GetComponent<MenuScript> ().SaveCategoryPosition (); //Saves the category window position
		if(PlayerPrefs.GetInt ("Tutorial1Finished") == 0)
		{
			//This line is only used for analytics purposes
			Analytics.CustomEvent("Level Start", new Dictionary<string, object>
			                      {
				{ "levelNumber", level }
			});

			Application.LoadLevel ("tutorialScene");
		}
		else
		{
            //This line is only used for analytics purposes
            Analytics.CustomEvent("Level Start", new Dictionary<string, object>
            {
                { "levelNumber", level }
            });

            //This line is used to load the scene
            Application.LoadLevel ("gameScene");
		}
	}

	public void InputLevel(){
		GameObject inputField = transform.FindChild ("InputField").FindChild ("Text").gameObject;
	
		int levelNumber = int.Parse (inputField.GetComponent<Text> ().text);
        LoadLevel (levelNumber);
	}

	public void LoadAchievementsLevel(){
		Application.LoadLevel ("achievements");
	}





}
