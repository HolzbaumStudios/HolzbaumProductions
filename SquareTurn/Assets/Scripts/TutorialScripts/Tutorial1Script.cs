using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Tutorial1Script : MonoBehaviour {

	public GameObject[] squareContainerRow0;
	public GameObject[] squareContainerRow1;
	public GameObject[] squareContainerRow2;
	public GameObject[] squareContainerRow3;

	public GameObject[] messagePanels;

	private bool checkForUserInput = true;
	private int currentStep;

	void Start()
	{
		ExecuteStep(0); //Execute the first step
	}

	void Update()
	{
		if(checkForUserInput)
		{
			if(Input.touchCount > 0 || Input.GetMouseButtonDown(0))
			{
				ExecuteStep(currentStep + 1);
			}
		}
	}

	public void ExecuteStep(int stepNumber)
	{
		currentStep = stepNumber;
		Debug.Log (currentStep);
		switch(stepNumber)
		{
			case 1: //Changed to second message
			{
				messagePanels[0].transform.FindChild("Text1").gameObject.SetActive(false);
				messagePanels[0].transform.FindChild("Text2").gameObject.SetActive(true);
			}break;
			case 2: //Show message and arrow to click the button
			{
				checkForUserInput = false;

				messagePanels[0].transform.FindChild("Text2").gameObject.SetActive(false);
				messagePanels[0].SetActive(false);
				messagePanels[1].SetActive(true);

				//Enable the first button
				squareContainerRow2[2].GetComponent<Button>().enabled = true;
			}break;
			case 3: //Turn squares 1
			{
				//Disable button again
				squareContainerRow2[2].GetComponent<Button>().enabled = false;
				//Turn squares
				squareContainerRow1[1].GetComponent<TurnScriptTutorial>().TurnSquare(1);
				squareContainerRow1[2].GetComponent<TurnScriptTutorial>().TurnSquare(1);
				squareContainerRow1[3].GetComponent<TurnScriptTutorial>().TurnSquare(1);
				squareContainerRow2[1].GetComponent<TurnScriptTutorial>().TurnSquare(1);
				squareContainerRow2[2].GetComponent<TurnScriptTutorial>().TurnSquare(1);
				squareContainerRow2[3].GetComponent<TurnScriptTutorial>().TurnSquare(1);
				squareContainerRow3[1].GetComponent<TurnScriptTutorial>().TurnSquare(1);
				squareContainerRow3[2].GetComponent<TurnScriptTutorial>().TurnSquare(1);
				squareContainerRow3[3].GetComponent<TurnScriptTutorial>().TurnSquare(1);

				messagePanels[1].SetActive(false);
				StartCoroutine(WaitSomeTime(1.0f));
			}break;
			case 4: //Show the the next message after 1.5 seconds
			{
				messagePanels[0].SetActive(true);
				messagePanels[0].transform.FindChild("Text4").gameObject.SetActive(true);
				//enable touch input again
				checkForUserInput = true;
			}break;
			case 5: //Show the message to tap the next square
			{
				//enable touch input again
				checkForUserInput = false;

				messagePanels[0].transform.FindChild("Text4").gameObject.SetActive(false);
				messagePanels[0].SetActive(false);
				messagePanels[2].SetActive(true);
				//enable the next square
				squareContainerRow1[2].GetComponent<Button>().enabled = true;
			}break;
			case 6: //Turn squares Nr. 2
			{
				//Disable button again
				squareContainerRow1[2].GetComponent<Button>().enabled = false;
				messagePanels[2].transform.FindChild("Text5").gameObject.SetActive(false);
				messagePanels[2].SetActive(false);
				//Turn squares
				squareContainerRow0[1].GetComponent<TurnScriptTutorial>().TurnSquare(1);
				squareContainerRow0[2].GetComponent<TurnScriptTutorial>().TurnSquare(1);
				squareContainerRow0[3].GetComponent<TurnScriptTutorial>().TurnSquare(1);
				squareContainerRow1[1].GetComponent<TurnScriptTutorial>().TurnSquare(0);
				squareContainerRow1[2].GetComponent<TurnScriptTutorial>().TurnSquare(0);
				squareContainerRow1[3].GetComponent<TurnScriptTutorial>().TurnSquare(0);
				squareContainerRow2[1].GetComponent<TurnScriptTutorial>().TurnSquare(0);
				squareContainerRow2[2].GetComponent<TurnScriptTutorial>().TurnSquare(0);
				squareContainerRow2[3].GetComponent<TurnScriptTutorial>().TurnSquare(0);

				StartCoroutine(WaitSomeTime(1.0f));
			}break;
			case 7: //Show the next message
			{
				messagePanels[0].SetActive(true);
				messagePanels[0].transform.FindChild("Text6").gameObject.SetActive(true);
				
				//enable touch input again
				checkForUserInput = true;
			}break;
			case 8: //Show the next message
			{
				messagePanels[0].transform.FindChild("Text6").gameObject.SetActive(false);
				messagePanels[0].transform.FindChild("Text7").gameObject.SetActive(true);
			}break;
			case 9: //Show the message to reload the game
			{
				checkForUserInput = false;

				messagePanels[0].transform.FindChild("Text7").gameObject.SetActive(false);
				messagePanels[0].SetActive(false);
				messagePanels[2].SetActive(true);
				messagePanels[2].transform.FindChild("Text8").gameObject.SetActive(true);

				GameObject.Find ("resetPanel").GetComponent<Button>().enabled = true;
			}break;
			case 10: //Reload the level
			{
				//Disable button again
				GameObject.Find ("resetPanel").GetComponent<Button>().enabled = false;
				messagePanels[2].SetActive(false);
				//Turn squares
				squareContainerRow0[1].GetComponent<TurnScriptTutorial>().TurnSquare(0);
				squareContainerRow0[2].GetComponent<TurnScriptTutorial>().TurnSquare(0);
				squareContainerRow0[3].GetComponent<TurnScriptTutorial>().TurnSquare(0);
				squareContainerRow3[1].GetComponent<TurnScriptTutorial>().TurnSquare(0);
				squareContainerRow3[2].GetComponent<TurnScriptTutorial>().TurnSquare(0);
				squareContainerRow3[3].GetComponent<TurnScriptTutorial>().TurnSquare(0);

				StartCoroutine(WaitSomeTime(1.0f));
			}break;
		}
	}

	IEnumerator WaitSomeTime(float seconds)
	{
		yield return new WaitForSeconds(seconds);
		ExecuteStep(currentStep + 1);
	}
}
