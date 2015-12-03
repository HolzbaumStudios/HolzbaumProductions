using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class PrepareStatisticScene : MonoBehaviour {

	public GameObject[] statistics;

	void Start()
	{
		SetStatistics ();
	}

	void SetStatistics()
	{
		int countTotalStars = PlayerPrefs.GetInt ("Category1Stars") + PlayerPrefs.GetInt ("Category2Stars") + PlayerPrefs.GetInt ("Category3Stars");

		statistics [0].GetComponent<Text> ().text = PlayerPrefs.GetInt ("TotalNumberOfMoves").ToString ();
		statistics [1].GetComponent<Text> ().text = PlayerPrefs.GetInt ("TotalNumberOfTurns").ToString ();
		statistics [2].GetComponent<Text> ().text = PlayerPrefs.GetInt ("NumberOfStartedLevels").ToString ();
		statistics [3].GetComponent<Text> ().text = PlayerPrefs.GetInt ("NumberOfCompletedLevels").ToString ();
		statistics [4].GetComponent<Text> ().text = PlayerPrefs.GetInt ("PerfectedLevels").ToString ();
		statistics [5].GetComponent<Text> ().text = countTotalStars.ToString ();
		statistics [6].GetComponent<Text> ().text = PlayerPrefs.GetInt ("TotalNumberOfResets").ToString ();
		statistics [7].GetComponent<Text> ().text = PlayerPrefs.GetInt ("NumberOfAppStarts").ToString ();
	}
}
