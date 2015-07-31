using UnityEngine;
using System.Collections;

public class CheckForAchievements : MonoBehaviour {

	//Assign to main menu canvas

	public GameObject achievementPanel;

	// Use this for initialization
	void Start () {
		StartCoroutine (CheckAchievements());
	}

	//Checks for new Achievements every 1.5 seconds
	IEnumerator CheckAchievements()
	{
		do
		{
			yield return new WaitForSeconds(1.5f);
			if (PlayerPrefs.GetInt ("NewAchievement") == 1) {
				GameObject.Find ("UserStatistics").GetComponent<AchievementCollection>().SetAchievementWindow(achievementPanel);
			}
		}while( 1 == 1);
	}

}
