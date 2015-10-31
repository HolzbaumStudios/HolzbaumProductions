using UnityEngine;
using System.Collections;

public class CheckAchievementsAtStart : MonoBehaviour {

	//This script is mainly made for the main menu, because there is no other script who could call this function

	
	// Use this for initialization
	void Start () {
		GameObject userStatistics = GameObject.Find ("UserStatistics");
		GameObject achievementPanel = GameObject.Find ("AchievementPanel");

		int numberOfAppStarts = PlayerPrefs.GetInt ("NumberOfAppStarts");
		
		if(userStatistics.GetComponent<AchievementCollection>().GetLocalAchievementState(13) == 0)
		{
			if(numberOfAppStarts >= 5)
			{
				userStatistics.GetComponent<AchievementCollection>().SetLocalAchievementState (13,1);
				PlayerPrefs.SetInt ("NewAchievement", 1); //Set the newAchievement playerPref always after setting the achievementStates
				achievementPanel.GetComponent<CheckForAchievements> ().CheckAchievements ();
			}
		}
		else if(userStatistics.GetComponent<AchievementCollection>().GetLocalAchievementState(14) == 0)
		{

			if(numberOfAppStarts >= 20)
			{
				userStatistics.GetComponent<AchievementCollection>().SetLocalAchievementState (14,1);
				PlayerPrefs.SetInt ("NewAchievement", 1); //Set the newAchievement playerPref always after setting the achievementStates
				achievementPanel.GetComponent<CheckForAchievements> ().CheckAchievements ();
			}
		}
		else if(userStatistics.GetComponent<AchievementCollection>().GetLocalAchievementState(15) == 0)
		{
			if(numberOfAppStarts >= 40)
			{
				userStatistics.GetComponent<AchievementCollection>().SetLocalAchievementState (15,1);
				PlayerPrefs.SetInt ("NewAchievement", 1); //Set the newAchievement playerPref always after setting the achievementStates
				achievementPanel.GetComponent<CheckForAchievements> ().CheckAchievements ();
			}
		}
	}
}
