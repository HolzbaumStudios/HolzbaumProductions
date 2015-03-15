using UnityEngine;
using System.Collections;

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
}
