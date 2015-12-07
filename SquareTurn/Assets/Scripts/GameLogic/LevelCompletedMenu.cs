using UnityEngine;
using System.Collections;
using UnityEngine.Analytics;
using System.Collections.Generic;

public class LevelCompletedMenu : MonoBehaviour {
	//This script is attached to the GameEndPanel in the game Scene
	//It contains the functions for the buttons of said panel

	private GameObject userStatistics;
	public GameObject endGameBackgroundLandscape;
	public GameObject endGameBackgroundPortrait;

	void Start()
	{
		userStatistics = GameObject.Find("UserStatistics");
		int levelNumber = PlayerPrefs.GetInt ("ChosenLevel");
		if(levelNumber == 123 || levelNumber == 223 || levelNumber == 323)
		{
			DisableContinue();
		}
	}

	public void ResetLevel()
	{
		endGameBackgroundLandscape.SetActive (false);
		endGameBackgroundPortrait.SetActive (false);
		userStatistics.GetComponent<UserStatistics>().UpdateStatistic("Resets++",1);
		userStatistics.SendMessage ("StoreStatistics");
		Application.LoadLevel ("gameScene");
	}

	public void BackToMainMenu(){
		GameObject.Find("UserStatistics").SendMessage ("StoreStatistics");
		Application.LoadLevel ("levelMenu");

	}

	public void ContinueToNextLevel(){
		GameObject.Find ("UserStatistics").SendMessage ("StoreStatistics");
		//Count up started level statistic
		int startedLevels = PlayerPrefs.GetInt ("NumberOfStartedLevels");
		startedLevels++;
		PlayerPrefs.SetInt ("NumberOfStartedLevels", startedLevels);
		//Count up levelnumber
		int levelNumber = PlayerPrefs.GetInt ("ChosenLevel");
		levelNumber ++;

        //This line is only used for analytics purposes
        Analytics.CustomEvent("Level Start", new Dictionary<string, object>
        {
            { "levelNumber", levelNumber }
        });

        PlayerPrefs.SetInt ("ChosenLevel", levelNumber);
		Application.LoadLevel ("gameScene");
	}

	public void DisableContinue()
	{
		transform.FindChild("ContinueButton").gameObject.SetActive(false);
	}
}








