using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class AchievementsProgressScript : MonoBehaviour {

	[Range(1,30)]
	public int numberOfAchievements;

	public GameObject progressCircle;
	public GameObject progressPercent;


	private int unlockedAchievements;
	private int completedPercent;
	
	// Update is called once per frame
	void Start () {


		unlockedAchievements = PlayerPrefs.GetInt ("UnlockedAchievements");
		unlockedAchievements = 4;
		completedPercent = 100 / numberOfAchievements * unlockedAchievements;

		progressCircle.GetComponent<Image>().fillAmount = completedPercent/100f;
		progressPercent.GetComponent<Text>().text = completedPercent.ToString ();
	
	}
}
