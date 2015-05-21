using UnityEngine;
using System.Collections;

public class MenuScript : MonoBehaviour {


	public IEnumerator StartLevel(){
		yield return new WaitForSeconds(0.1f);
		Application.LoadLevel ("gameScene");
	}

	public void GoBackToMenu(){
		GameObject.Find("UserStatistics").SendMessage ("StoreStatistics");
		Application.LoadLevel ("levelMenu");
	}

	void Update(){
		if(Input.GetKeyDown(KeyCode.Escape))
		{
			Debug.Log ("Pressed");
			Application.LoadLevel("startMenu");
		}
	}

}
