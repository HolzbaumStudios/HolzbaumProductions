using UnityEngine;
using System.Collections;

public class LevelCompletedMenu : MonoBehaviour {
	//This script is attached to the GameEndPanel in the game Scene
	//It contains the functions for the buttons of said panel

	private GameObject userStatistics;
	public GameObject endGameBackgroundLandscape;
	public GameObject endGameBackgroundPortrait;

	void Start()
	{
		userStatistics = GameObject.Find("UserStatistics");
	}

	public void ResetLevel()
	{
		endGameBackgroundLandscape.SetActive (false);
		endGameBackgroundPortrait.SetActive (false);
		userStatistics.GetComponent<UserStatistics>().UpdateStatistic("Resets++",1);
		userStatistics.SendMessage ("StoreStatistics");
		Application.LoadLevel ("gameScene");
	}

	public void BackToMainMenu(){
		GameObject.Find("UserStatistics").SendMessage ("StoreStatistics");
		Application.LoadLevel ("levelMenu");

	}

}
