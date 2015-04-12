using UnityEngine;
using System.Collections;

public class CheckForAchievements : MonoBehaviour {

	public GameObject achievementPanel;

	// Use this for initialization
	void Start () {
		PlayerPrefs.SetInt ("NewAchievement", 1);

		if (PlayerPrefs.GetInt ("NewAchievement") == 1) {
			GameObject.Find ("UserStatistics").GetComponent<AchievementCollection>().SetAchievementWindow(achievementPanel);
		}
	}

}
