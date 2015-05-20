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
		Application.LoadLevel ("gameScene");
	}

	public void InputLevel(){
		GameObject inputField = transform.FindChild ("InputField").FindChild ("Text").gameObject;

	
		int levelNumber = int.Parse (inputField.GetComponent<Text> ().text);

		LoadLevel (levelNumber);
	}

	public void LoadAchievementsLevel(){
		Application.LoadLevel ("achievements");
	}


	void Update(){
		if(Input.GetKeyDown(KeyCode.Escape))
		{
			Application.LoadLevel("startMenu");
		}
	}


}
