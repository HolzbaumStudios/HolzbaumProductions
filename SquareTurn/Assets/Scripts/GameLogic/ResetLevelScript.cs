using UnityEngine;
using System.Collections;

public class ResetLevelScript : MonoBehaviour {

	//Load the level again
	public void ReloadLevel(){
		GameObject.Find("UserStatistics").SendMessage ("StoreStatistics");
		Application.LoadLevel ("gameScene");
	}
}
