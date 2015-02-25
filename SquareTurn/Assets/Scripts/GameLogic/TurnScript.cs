using UnityEngine;
using System.Collections;

public class TurnScript : MonoBehaviour {

	private int row;
	private int column;

	//---------------FUNCTIONS-------------------------------
	public void StartSquareTurn(){

		GameObject.Find ("UserStatistics").SendMessage ("UpdateStatistic", "Turn++"); //Update the turn statistics (Script: UserStatistics.cs)

		GameObject.Find ("gameManager").SendMessage ("TurnOtherSquares", gameObject.name);
	}

	public void TurnSquare(int squareState){
		animation.Play ();
		StartCoroutine(AnimationSettings(squareState));
	}

	//Sets the color of the square
	IEnumerator AnimationSettings(int squareState){
		yield return new WaitForSeconds(0.5f);
		//Set Color
		Color squareColor = Color.blue;
		switch(squareState){
			case 0:squareColor = new Color32(72, 120, 168, 255);
			break;
			case 1:squareColor = new Color32(240, 120, 48, 255);
			break;
			case 3:squareColor = Color.red;
			break;
		}
		transform.GetComponent<UnityEngine.UI.Image>().color = squareColor;
		yield return new WaitForSeconds(0.6f);
		//Set Rotation
		transform.eulerAngles = new Vector3(0,0,0);
	}
	
}
