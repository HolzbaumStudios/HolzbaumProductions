using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class SetCategoryInfo : MonoBehaviour {

	//Sets the number of achieved stars in the level catecory choice
	//Assign script to the UI.Text GameObject

	public int categoryNumber;
	public string maxStars = "72";


	// Use this for initialization
	void Start () {
		string playerPrefName = "Category" + categoryNumber + "Stars";
		string achievedStars = PlayerPrefs.GetInt(playerPrefName).ToString();

		string displayText = achievedStars + " / " + maxStars;
		GetComponent<Text> ().text = displayText;
	}

}
