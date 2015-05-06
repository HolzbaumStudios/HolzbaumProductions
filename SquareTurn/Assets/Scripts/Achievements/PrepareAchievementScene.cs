using UnityEngine;
using System.Collections;

public class PrepareAchievementScene : MonoBehaviour {

	//Assign to AchievementContainer

	// Use this for initialization
	void Start () {
		//Call the function to set achievements to unlocked
		GameObject.Find ("UserStatistics").GetComponent<AchievementCollection>().PrepareAchievementScene();
	}

}
