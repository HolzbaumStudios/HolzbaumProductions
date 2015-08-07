using UnityEngine;
using System.Collections;
using UnityEngine.UI;

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
			if(level >= 100 && level < 200)
			{
				Application.LoadLevel ("tutorialScene");
			}
			else
			{
				Application.LoadLevel ("gameScene");
			}
		}
		else
		{
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
