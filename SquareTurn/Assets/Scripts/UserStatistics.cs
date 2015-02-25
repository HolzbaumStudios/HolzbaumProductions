using UnityEngine;
using System.Collections;

public class UserStatistics : MonoBehaviour {

	/// <summary>
	/// This script is used to store all the user statistics in Prefabs.
	/// The Object is opened on the beginning and is set to not destroy on load 
	/// </summary>
	/// 

	/// --------------------------Variables--------------------------------------------------- 
	// (PlayerPref variables have the same name, but start with a capital letter)

	int totalNumberOfTurns;  //How many squares the user has turned in the whole game

	// ---------------------------INITIALIZATION----------------------------------------------
	
	void Start(){
		//Store the prefabs in the local variables
		totalNumberOfTurns = PlayerPrefs.GetInt ("TotalNumberOfTurns");

	}

	// --------------------------FUNCTIONS---------------------------------------------------

	//Update the statistic, depending on the transmitted String
	void UpdateStatistic(string statisticName){

		switch (statisticName) {
			case "Turn++": totalNumberOfTurns++;
			break;
		}

		Debug.Log (totalNumberOfTurns);
	}




	//Store the variables into prefabs
	public void StoreStatistics(){
		PlayerPrefs.SetInt ("TotalNumberOfTurns", totalNumberOfTurns);
	}

	
}