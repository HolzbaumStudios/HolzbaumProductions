using UnityEngine;
using System.Collections;

public class TurnScriptTutorial : MonoBehaviour {

	private int row;
	private int column;
	private GameObject managerObject;

	//----------------INITIALIZATION-----------------------------------------
	void Start(){
		managerObject = GameObject.Find ("gameManager");;
	}

	//---------------FUNCTIONS-------------------------------
	public void StartSquareTurn(int stepNumber){
		
		managerObject.GetComponent<Tutorial1Script>().ExecuteStep(stepNumber);
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

	public void TurnFinalSquares(int squareNumber) //0 = downLeft, 03 = downRight, 30 = upLeft, 33 = upRight
	{
		managerObject.GetComponent<Tutorial1Script>().TurnLastSquares(squareNumber);
	}
	
}
