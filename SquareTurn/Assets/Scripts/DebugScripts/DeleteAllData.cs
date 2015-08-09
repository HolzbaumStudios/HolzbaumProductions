using UnityEngine;
using System.Collections;

public class DeleteAllData : MonoBehaviour {

	public void DeleteData()
	{


		PlayerPrefs.DeleteAll ();

		//Set Variables
		GameObject userStatistics = GameObject.Find ("UserStatistics");
		userStatistics.GetComponent<AchievementCollection> ().SetAchievementsBack ();
		userStatistics.GetComponent<UserStatistics> ().SetStatisticsBack ();

		Debug.Log ("Data deleted!");
	}
}
