using UnityEngine;
using System.Collections;

public class CheckForAchievements : MonoBehaviour {

	public GameObject achievementPanel;

	// Use this for initialization
	void Start () {
		PlayerPrefs.SetInt ("NewAchievement", 1);

		if (PlayerPrefs.GetInt ("NewAchievement") == 1) {
			achievementPanel.SetActive (true);
			achievementPanel.GetComponent<Animation>().Play ();
		}
	}

}
