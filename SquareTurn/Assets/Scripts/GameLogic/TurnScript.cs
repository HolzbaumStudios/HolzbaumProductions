using UnityEngine;
using System.Collections;

public class TurnScript : MonoBehaviour {

	private int row;
	private int column;
	private GameObject managerObject;
	private GameObject userStatistics;

	//----------------INITIALIZATION-----------------------------------------
	void Start(){
		managerObject = GameObject.Find ("gameManager");
		userStatistics = GameObject.Find ("UserStatistics");
	}

	//---------------FUNCTIONS-------------------------------
	public void StartSquareTurn(){

		bool gameWon = managerObject.GetComponent<GameLogic>().ReturnWinningState();

		if (!gameWon) { //only turn squares if game not won

			userStatistics.GetComponent<UserStatistics>().UpdateStatistic("Move++",1); //Update the turn statistics (Script: UserStatistics.cs)
			managerObject.SendMessage ("TurnOtherSquares", gameObject.name);
		}
	}

	public void TurnSquare(int squareState){
		GetComponent<Animation>().Play ();
		StartCoroutine(AnimationSettings(squareState));
	}

	//Sets the color of the square
	IEnumerator AnimationSettings(int squareState){
		yield return new WaitForSeconds(0.25f);
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
