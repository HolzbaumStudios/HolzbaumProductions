using UnityEngine;
using System.Collections;

public class LevelCompletedMenu : MonoBehaviour {
	//This script is attached to the GameEndPanel in the game Scene
	//It contains the functions for the buttons of said panel

	private GameObject userStatistics;
	private GameObject endGameBackground;

	void Start()
	{
		endGameBackground = transform.parent.gameObject;
		userStatistics = GameObject.Find("UserStatistics");
	}

	public void ResetLevel()
	{
		endGameBackground.SetActive (false);
		userStatistics.GetComponent<UserStatistics>().UpdateStatistic("Resets++",1);
		userStatistics.SendMessage ("StoreStatistics");
		endGameBackground.SetActive (false);
		Application.LoadLevel ("gameScene");
	}

	public void BackToMainMenu(){
		GameObject.Find("UserStatistics").SendMessage ("StoreStatistics");
		Application.LoadLevel ("levelMenu");

	}

}
