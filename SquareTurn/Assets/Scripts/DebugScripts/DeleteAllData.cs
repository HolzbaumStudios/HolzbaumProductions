using UnityEngine;
using System.Collections;

public class DeleteAllData : MonoBehaviour {

	public void DeleteData()
	{


		PlayerPrefs.DeleteAll ();

		//Set Variables
		GameObject userStatistics = GameObject.Find ("UserStatistics");
		userStatistics.GetComponent<AchievementCollection> ().SetAchievementsBack ();

		Debug.Log ("Data deleted!");
	}
}
