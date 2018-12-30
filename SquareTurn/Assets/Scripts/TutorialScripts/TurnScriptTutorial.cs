using UnityEngine;
using System.Collections;

public class TurnScriptTutorial : MonoBehaviour {

	private int row;
	private int column;
	public GameObject managerObject;

	//---------------FUNCTIONS-------------------------------
	public void StartSquareTurn(int stepNumber){
		
		managerObject.GetComponent<Tutorial1Script>().ExecuteStep(stepNumber);
	}

	public void TurnSquare(int squareState){
        if (squareState == 1)
        {
            GetComponent<Animation>().Play("turnAnimation");
        }
        else
        {
            GetComponent<Animation>().Play("reverseTurnAnimation");
        }
	}


	public void TurnFinalSquares(int squareNumber) //0 = downLeft, 03 = downRight, 30 = upLeft, 33 = upRight
	{
		managerObject.GetComponent<Tutorial1Script>().TurnLastSquares(squareNumber);
	}
	
}
