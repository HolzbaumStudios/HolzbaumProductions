using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using TMPro;

public class PrepareStatisticScene : MonoBehaviour {

	public TextMeshProUGUI[] statistics;
    private LevelStatistics levelStatistics;

	void Start()
	{
        levelStatistics = LevelStatistics.GetInstance();
		SetStatistics ();
	}

	void SetStatistics()
	{
		int countTotalStars = PlayerPrefs.GetInt ("Category1Stars") + PlayerPrefs.GetInt ("Category2Stars") + PlayerPrefs.GetInt ("Category3Stars");

		statistics [0].text = PlayerPrefs.GetInt ("TotalNumberOfMoves").ToString ();
		statistics [1].text = PlayerPrefs.GetInt ("TotalNumberOfTurns").ToString ();
		statistics [2].text = PlayerPrefs.GetInt ("NumberOfStartedLevels").ToString ();
		statistics [3].text = levelStatistics.GetTotalCompletedLevels().ToString ();
		statistics [4].text = PlayerPrefs.GetInt ("PerfectedLevels").ToString ();
		statistics [5].text = countTotalStars.ToString ();
		statistics [6].text = PlayerPrefs.GetInt ("TotalNumberOfResets").ToString ();
		statistics [7].text = PlayerPrefs.GetInt ("NumberOfAppStarts").ToString ();
	}
}
