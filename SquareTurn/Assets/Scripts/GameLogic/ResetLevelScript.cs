using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class ResetLevelScript : MonoBehaviour {

	private GameObject userStatistics;

	
	void Start(){
		userStatistics = GameObject.Find("UserStatistics");
	}

	//Load the level again
	public void ReloadLevel(){
		userStatistics.GetComponent<UserStatistics>().UpdateStatistic("Resets++",1);
		userStatistics.SendMessage ("StoreStatistics");
        SceneManager.LoadScene("gameScene");
	}
}
