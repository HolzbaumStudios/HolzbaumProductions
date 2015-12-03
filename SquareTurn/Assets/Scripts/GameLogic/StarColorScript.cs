using UnityEngine;
using System.Collections;

public class StarColorScript : MonoBehaviour {

	///---------------------------------------
	/// Script description
	/// 
	/// This script is assigned to every star.
	/// At the beginning of the levelChoice the color of the star is set
	/// 


	//Prefabsname ---> StarsLevelN  --> N = Number of Level

	public int starNumber; //From 1 to 3 .. left to right
	public int levelNumber; //to which level the star belongs

	private int achievedStars; //Saves the prefab in this variable
	private string prefabName; //The name of the prefab

	// Use this for initialization
	void Start () {;
		prefabName = "StarsLevel" + levelNumber;
		achievedStars = PlayerPrefs.GetInt (prefabName);

		//If star was reached
		if (achievedStars >= starNumber) {
			//...color it
			transform.GetComponent<UnityEngine.UI.Image>().color = Color.yellow;
		}
	}
	

}
