using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class AchievementsProgressScript : MonoBehaviour {

	[Range(1,30)]
	public int numberOfAchievements;

	public GameObject progressCircle;
	public GameObject progressPercent;


	private int unlockedAchievements = 0;
	private float completedPercent;
	
	// Update is called once per frame
	void Start () {
		string achievementName = "";
		for(int i = 0; i < numberOfAchievements; i++)
		{
			achievementName = "Achievement" + i + "State";
			int achievementState = PlayerPrefs.GetInt(achievementName);
			if(achievementState > 0)
			{
				unlockedAchievements++;
			}
		}

		//Debug.Log ("Number of achievements: " + numberOfAchievements);
		//Debug.Log ("Unlocked achievements: " + unlockedAchievements);

		completedPercent = (100f / numberOfAchievements) * unlockedAchievements;
		//Debug.Log ("Percent: " + completedPercent);
		int completedPercentInt = (int)completedPercent;

		progressCircle.GetComponent<Image>().fillAmount = completedPercentInt/100f;
		progressPercent.GetComponent<Text>().text = completedPercentInt.ToString ();
	
	}
}
