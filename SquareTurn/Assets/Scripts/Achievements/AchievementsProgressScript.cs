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
			if(PlayerPrefs.GetInt(achievementName) == 2)
			{
				unlockedAchievements++;
			}
		}

		completedPercent = 100 / numberOfAchievements * unlockedAchievements;
		int completedPercentInt = (int)completedPercent;

		progressCircle.GetComponent<Image>().fillAmount = completedPercentInt/100f;
		progressPercent.GetComponent<Text>().text = completedPercentInt.ToString ();
	
	}
}
