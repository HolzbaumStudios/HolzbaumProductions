using UnityEngine;
using System.Collections;

public class ResetLevelScript : MonoBehaviour {

	//Load the level again
	public void ReloadLevel(){
		Application.LoadLevel ("gameScene");
	}
}
