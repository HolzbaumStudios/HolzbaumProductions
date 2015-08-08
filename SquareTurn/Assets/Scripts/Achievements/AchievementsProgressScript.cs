using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class AchievementsProgressScript : MonoBehaviour {

	[Range(1,30)]
	public int numberOfAchievements;

	public GameObject progressCircle;
	public GameObject progressPercent;


	private int unlockedAchievements = 0;
	private int completedPercent;
	
	// Update is called once per frame
	void Start () {
		string achievementName = "";
		for(int i = 0; i < numberOfAchievements; i++)
		{
			achievementName = "Achievement" + i + "State";
			if(PlayerPrefs.GetInt(achievementName) == 2)
			{
				unlockedAchievements++;
			}
		}

		completedPercent = 100 / numberOfAchievements * unlockedAchievements;

		progressCircle.GetComponent<Image>().fillAmount = completedPercent/100f;
		progressPercent.GetComponent<Text>().text = completedPercent.ToString ();
	
	}
}
