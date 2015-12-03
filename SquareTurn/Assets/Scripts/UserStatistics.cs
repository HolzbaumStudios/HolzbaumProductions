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

	int totalNumberOfMoves;  //How many moves the user has made in the whole game
	int totalNumberOfTurns; //How many squares the user has turned in the whole game
	int totalNumberOfResets;

	// ---------------------------INITIALIZATION----------------------------------------------
	
	void Start(){
		//Store the prefabs in the local variables
		totalNumberOfMoves = PlayerPrefs.GetInt ("TotalNumberOfMoves");
		totalNumberOfTurns = PlayerPrefs.GetInt ("TotalNumberOfTurns");
		totalNumberOfResets = PlayerPrefs.GetInt ("TotalNumberOfResets");
	}

	// --------------------------FUNCTIONS---------------------------------------------------

	//Update the statistic, depending on the transmitted String
	public void UpdateStatistic(string statisticName, int amount){
		
		switch (statisticName) {
			case "Move++": totalNumberOfMoves++;
			break;
			case "Turns++": totalNumberOfTurns = totalNumberOfTurns + amount;
			break;
			case "Resets++": totalNumberOfResets += amount;
			break;
		}

		StoreStatistics ();
		
	}




	//Store the variables into prefabs
	public void StoreStatistics(){
		PlayerPrefs.SetInt ("TotalNumberOfMoves", totalNumberOfMoves);
		PlayerPrefs.SetInt ("TotalNumberOfTurns", totalNumberOfTurns);
		PlayerPrefs.SetInt ("TotalNumberOfResets", totalNumberOfResets);
	}

	//Resets all statistics when called by DeleteAllData
	public void SetStatisticsBack()
	{
		totalNumberOfMoves = 0;
		totalNumberOfTurns = 0;
		totalNumberOfResets = 0;
	}
	
}