using UnityEngine;
using System.Collections;

public class CheckForAchievements : MonoBehaviour {

	//Assign to main menu canvas

	public GameObject achievementPanel;

	// Use this for initialization
	public void CheckAchievements () {
		if (PlayerPrefs.GetInt ("NewAchievement") == 1) {
			Debug.Log ("Checking Achievements");
			GameObject.Find ("UserStatistics").GetComponent<AchievementCollection>().SetAchievementWindow(achievementPanel);
		}
	}

}
