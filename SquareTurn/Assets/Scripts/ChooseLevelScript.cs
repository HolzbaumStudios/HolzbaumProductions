using UnityEngine;
using System.Collections;

public class ChooseLevelScript : MonoBehaviour {
	

	public void LoadLevel(int level){
		PlayerPrefs.SetInt ("ChosenLevel", level);
		Application.LoadLevel ("gameScene");
	}
}
