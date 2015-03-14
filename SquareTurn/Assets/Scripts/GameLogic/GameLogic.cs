using UnityEngine;
using System.Collections;

public class GameLogic : MonoBehaviour {

	//--------------Variables----------------
	int fieldRows;
	int fieldColumns;
	float squareSpace = Screen.width/12.3f; //The spacing between the squares  --> otherwise 120 //before 13.3 -> /14 
	float squareSize = Screen.width/13; //before 13.3 -> /15

	public GameObject squareObject;
	public GameObject turnText;
	public bool playerWon = false;
	LevelScript levelScript;
	private GameObject userStatistics;
	private int numberOfTurns; //To count how many squares have been turned --> for statistics

	//-----------------CLASSES---------------
	public class cSquareClass{
		public GameObject squareObject;
		public int squareState = 0; //States: 0 = wrongSide, 1 = rightSide, 2 = noSquare/wall, 3 = crossTurn

		public int GetSquareState()
		{
			return squareState;
		}

		public void SetSquareState(int newState){
			squareState = newState;
		}
	}

	//----------------CLASS Object----------
	cSquareClass[,] squareArray;

	//-------------------------START--------------------------------
	void Start () {
		userStatistics = GameObject.Find ("UserStatistics");

		levelScript = GameObject.Find ("LevelScript").GetComponent<LevelScript>();

		//Get Rows and Columns
		fieldRows = levelScript.rows;
		fieldColumns = levelScript.columns;

		InitializeArray (fieldRows, fieldColumns); //Initializes the array
		PrepareField (); //Prepares the field with the buttons
	}


	//-------------FUNCTIONS-------------------------------
	void InitializeArray(int rows, int columns){
		squareArray = new cSquareClass[rows, columns];

		//Initialize the Array
		for(int i = 0; i < rows; i++)
		{
			for(int j = 0; j < columns; j++)
			{	
				squareArray[i,j] = new cSquareClass();
			}
		}
	}

	//Set all the fields
	void PrepareField(){

		bool evenNumberWidth = false;
		bool evenNumberHeight = false;


		//Check if Width and Height is even
		if(fieldRows%2==0){
			evenNumberHeight = true;
		} 
		if (fieldColumns % 2 == 0) {
			evenNumberWidth = true;
		}

		//Create Field Rows
		for (int i = 0; i < fieldRows; i++) {
			float yPosition; //Stores the height of the square
			if(evenNumberHeight)
			{
				float halfField = fieldRows / 2;
				float difference = halfField - i;
				yPosition = -difference * squareSpace + squareSpace/2;
			}else{
				float halfField = fieldRows / 2;
				float difference = halfField - i;
				yPosition = -difference * squareSpace;
			}


			//Create the field columns
			for (int j = 0; j < fieldColumns; j++){
				//GET THE VALUES FROM THE LEVEL
				squareArray[i,j].squareState = levelScript.fieldStructureArray[i,j];
				//Debug.Log (squareArray[i,j].squareState);
				//Create the square
				if(squareArray[i,j].squareState == 0 || squareArray[i,j].squareState == 1 || squareArray[i,j].squareState == 3){
					GameObject column = Instantiate(squareObject,transform.position,transform.rotation) as GameObject;
					squareArray[i,j].squareObject = column;
					column.transform.parent = GameObject.Find ("squarePanel").transform;
					column.name = "r"+i+"c" +j;
					//if state is set to 1 change the color
					if(squareArray[i,j].squareState == 1){
						column.transform.GetComponent<UnityEngine.UI.Image>().color = Color.yellow;
					}
					if(squareArray[i,j].squareState == 3){
						column.transform.GetComponent<UnityEngine.UI.Image>().color = Color.red;
					}
					//Set position regarding width count
					if(evenNumberWidth)
					{
						float halfField = fieldColumns / 2;
						float difference = halfField - j;
						column.GetComponent<RectTransform>().anchoredPosition = new Vector2(-difference * squareSpace + squareSpace/2,yPosition);
						//Debug.Log (i + "," + j+ "   X: " + (-difference * squareSpace + squareSpace/2) + " Y: " + yPosition);
					}else{
						float halfField = fieldColumns / 2;
						float difference = halfField - j;
						column.GetComponent<RectTransform>().anchoredPosition = new Vector2(-difference * squareSpace,yPosition);
						//Debug.Log (i + "," + j+ "   X: " + (-difference * squareSpace) + " Y: " + yPosition);
					}
	
					//Set size of the square
					column.GetComponent<RectTransform>().sizeDelta = new Vector2(squareSize,squareSize);
				}
			}

		}
	}



	//Turn the squares around the klicked square
	public void TurnOtherSquares(string squareName){
		//Set the counter up
		int turnNumber;
		turnNumber = int.Parse(turnText.GetComponent<UnityEngine.UI.Text>().text);
		turnNumber++;
		
		turnText.GetComponent<UnityEngine.UI.Text>().text = turnNumber.ToString ();

		//Variables
		int row;
		int column;
		int tempRow;
		int tempColumn;
		row = int.Parse (squareName.Substring (1, 1)); //Get the second letter of the word and convert to string
		column = int.Parse (squareName.Substring (3, 1)); //Get the fourth letter of the word and convert to string


		//Get the value of the clicked square
		int clickedSquareState = squareArray[row,column].squareState;


		//TopRow
		//Square top left
		if(clickedSquareState == 0 || clickedSquareState == 1){
			tempRow = row + 1;
			tempColumn = column -1;
			if(tempRow >= 0 && tempRow < fieldRows && tempColumn >=0 && tempColumn < fieldColumns){
				int squareState = CheckSquareState (tempRow,tempColumn); //Get the new square value
				if(squareArray[tempRow,tempColumn].squareObject && (squareState == 1 || squareState == 0)){
					squareArray[tempRow,tempColumn].squareObject.SendMessage("TurnSquare", squareState); //Turn the square with the new value
					numberOfTurns++;
				}
			}
		}
		//Square top middle
		if(clickedSquareState == 0 || clickedSquareState == 1 || clickedSquareState == 3){
			tempRow = row + 1;
			tempColumn = column;
			if(tempRow >= 0 && tempRow < fieldRows && tempColumn >=0 && tempColumn < fieldColumns){
				int squareState = CheckSquareState (tempRow,tempColumn); //Get the new square value
				if(squareArray[tempRow,tempColumn].squareObject && (squareState == 1 || squareState == 0)){
					squareArray[tempRow,tempColumn].squareObject.SendMessage("TurnSquare", squareState); //Turn the square with the new value
					numberOfTurns++;
				}
			}
		}
		//Square top right
		if(clickedSquareState == 0 || clickedSquareState == 1){
			tempRow = row + 1;
			tempColumn = column + 1;
			if(tempRow >= 0 && tempRow < fieldRows && tempColumn >=0 && tempColumn < fieldColumns){
				int squareState = CheckSquareState (tempRow,tempColumn); //Get the new square value
				if(squareArray[tempRow,tempColumn].squareObject && (squareState == 1 || squareState == 0)){
					squareArray[tempRow,tempColumn].squareObject.SendMessage("TurnSquare", squareState); //Turn the square with the new value
					numberOfTurns++;
				}
			}
		}
		//Middle ROw
		//Square middle left
		if (clickedSquareState == 0 || clickedSquareState == 1 || clickedSquareState == 3) {
			tempRow = row;
			tempColumn = column - 1;
			if (tempRow >= 0 && tempRow < fieldRows && tempColumn >= 0 && tempColumn < fieldColumns) {
				int squareState = CheckSquareState (tempRow, tempColumn); //Get the new square value
				if (squareArray [tempRow, tempColumn].squareObject && (squareState == 1 || squareState == 0)){
						squareArray [tempRow, tempColumn].squareObject.SendMessage ("TurnSquare", squareState); //Turn the square with the new value
						numberOfTurns++;
				}
			}
		}
		//Square middle middle
		if (clickedSquareState == 0 || clickedSquareState == 1) {
			tempRow = row;
			tempColumn = column;
			if(tempRow >= 0 && tempRow < fieldRows && tempColumn >=0 && tempColumn < fieldColumns){
				int squareState = CheckSquareState (tempRow,tempColumn ); //Get the new square value
				if(squareArray[tempRow,tempColumn].squareObject && (squareState == 1 || squareState == 0)){ 
					squareArray[tempRow,tempColumn].squareObject.SendMessage("TurnSquare", squareState); //Turn the square with the new value
					numberOfTurns++;
				}
			}
		}
		//Square middle right
		if (clickedSquareState == 0 || clickedSquareState == 1 || clickedSquareState == 3) {
			tempRow = row;
			tempColumn = column + 1;
			if (tempRow >= 0 && tempRow < fieldRows && tempColumn >= 0 && tempColumn < fieldColumns) {
					int squareState = CheckSquareState (tempRow, tempColumn); //Get the new square value
					if (squareArray [tempRow, tempColumn].squareObject && (squareState == 1 || squareState == 0)){
							squareArray [tempRow, tempColumn].squareObject.SendMessage ("TurnSquare", squareState); //Turn the square with the new value
							numberOfTurns++;
					}
			}
		}
		//Bottom ROw
		//Square bottom left
		if (clickedSquareState == 0 || clickedSquareState == 1) {
			tempRow = row - 1;
			tempColumn = column - 1;
			if (tempRow >= 0 && tempRow < fieldRows && tempColumn >= 0 && tempColumn < fieldColumns) {
					int squareState = CheckSquareState (tempRow, tempColumn); //Get the new square value
					if (squareArray [tempRow, tempColumn].squareObject && (squareState == 1 || squareState == 0)){
							squareArray [tempRow, tempColumn].squareObject.SendMessage ("TurnSquare", squareState); //Turn the square with the new value
							numberOfTurns++;
					}
			}
		}
		//Square bottom middle
		if (clickedSquareState == 0 || clickedSquareState == 1 || clickedSquareState == 3) {
			tempRow = row - 1;
			tempColumn = column;
			if (tempRow >= 0 && tempRow < fieldRows && tempColumn >= 0 && tempColumn < fieldColumns) {
					int squareState = CheckSquareState (tempRow, tempColumn); //Get the new square value
					if (squareArray [tempRow, tempColumn].squareObject && (squareState == 1 || squareState == 0)){
							squareArray [tempRow, tempColumn].squareObject.SendMessage ("TurnSquare", squareState); //Turn the square with the new value
							numberOfTurns++;
					}
			}
		}
		//Square bottom right
		if (clickedSquareState == 0 || clickedSquareState == 1) {
			tempRow = row - 1;
			tempColumn = column + 1;
			if (tempRow >= 0 && tempRow < fieldRows && tempColumn >= 0 && tempColumn < fieldColumns) {
					int squareState = CheckSquareState (tempRow, tempColumn); //Get the new square value
					if (squareArray [tempRow, tempColumn].squareObject && (squareState == 1 || squareState == 0)){
							squareArray [tempRow, tempColumn].squareObject.SendMessage ("TurnSquare", squareState); //Turn the square with the new value
							numberOfTurns++;
					}
			}
		}

		//Send statistic to  userstatistics.cs
		userStatistics.GetComponent<UserStatistics>().UpdateStatistic("Turns++",numberOfTurns);
		numberOfTurns = 0;

		//Check if won
		CheckIfWon();
	}

	//Checks the state of the square and change it accordingly
	int CheckSquareState(int row, int column){
		if(squareArray[row,column].squareState == 0){
			squareArray[row,column].SetSquareState(1);
		}else if(squareArray[row,column].squareState == 1){
			squareArray[row,column].SetSquareState(0);
		}
		return squareArray[row,column].squareState;
	}


	//Check everyturn if the player has won
	void CheckIfWon(){
		playerWon = true;

		if (PlayerPrefs.GetInt ("ChosenLevel") < 400) { //Everything under 400 are normal lavels. 4xx are form levels
				for (int i = 0; i < fieldRows; i++) {
						for (int j = 0; j < fieldColumns; j++) {	
								if (squareArray [i, j].squareState == 0) {
										playerWon = false;
								}
						}
				}
		}

		if(playerWon){
			Debug.Log ("Gewonnen");
			//Store the statistics in Prefabs (Script: UserStatistics)
			userStatistics.SendMessage ("StoreStatistics");
		}
	}


	//When user tries to turn a square (TurnScript), it checks if the game is already won, by accessing this function
	public bool ReturnWinningState(){
		return playerWon;
	}




}
