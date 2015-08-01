using UnityEngine;
using System.Collections;

public class CheckAchievementsAtStart : MonoBehaviour {

	//This script is mainly made for the main menu, because there is no other script who could call this function

	
	// Use this for initialization
	void Start () {
		GameObject userStatistics = GameObject.Find ("UserStatistics");
		GameObject achievementPanel = GameObject.Find ("AchievementPanel");

		int numberOfAppStarts = PlayerPrefs.GetInt ("NumberOfAppStarts");

		if(numberOfAppStarts == 10)
		{
			userStatistics.GetComponent<AchievementCollection>().SetLocalAchievementState (13,1);
			PlayerPrefs.SetInt ("NewAchievement", 1); //Set the newAchievement playerPref always after setting the achievementStates
			achievementPanel.GetComponent<CheckForAchievements> ().CheckAchievements ();
		}
		else if(numberOfAppStarts == 50)
		{
			userStatistics.GetComponent<AchievementCollection>().SetLocalAchievementState (14,1);
			PlayerPrefs.SetInt ("NewAchievement", 1); //Set the newAchievement playerPref always after setting the achievementStates
			achievementPanel.GetComponent<CheckForAchievements> ().CheckAchievements ();
		}
		else if(numberOfAppStarts == 100)
		{
			userStatistics.GetComponent<AchievementCollection>().SetLocalAchievementState (15,1);
			PlayerPrefs.SetInt ("NewAchievement", 1); //Set the newAchievement playerPref always after setting the achievementStates
			achievementPanel.GetComponent<CheckForAchievements> ().CheckAchievements ();
		}
	}
}
