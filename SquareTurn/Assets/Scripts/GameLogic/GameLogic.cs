using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class GameLogic : MonoBehaviour {

	//--------------Variables----------------
	int fieldRows;
	int fieldColumns;
	float squareSpace = Screen.width/12.3f; //The spacing between the squares  --> otherwise 120 //before 13.3 -> /14 
	float squareSize = Screen.width/13; //before 13.3 -> /15
	int turnNumber;

	public GameObject squareObject;
	public GameObject turnTextLandscape;
	public GameObject turnTextPortrait;
	public bool playerWon = false;
	LevelScript levelScript;
	private GameObject userStatistics;
	private int numberOfTurns; //To count how many squares have been turned --> for statistics

	public GameObject gameEndPanel; //The panel which appears, when the level has been finished
	public GameObject treeContainer;
	private GameObject achievementPanel;

	//Variables to store achievement prefabs
	//The prefab values are stored in this variables (in the start function), because they have to be checked with every move.
	//Getting prefabs costs more than just checking a variable


	//-----------------CLASSES---------------
	public class cSquareClass{
		public GameObject squareObject;
		public int squareState = 0; //States: 0 = wrongSide (blue), 1 = rightSide (orange), 2 = noSquare/wall, 3 = crossTurn (red), 4 = edgeTurn (green), 5 = Yellow

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
		achievementPanel = GameObject.Find ("AchievementPanel");

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

		//If mode == portrait, set the square size depending on the height
		if(Screen.height > Screen.width)
		{
			squareSpace = Screen.height/12.3f; //The spacing between the squares  --> otherwise 120 //before 13.3 -> /14 
			squareSize = Screen.height/13; //before 13.3 -> /15
		}


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
				if(squareArray[i,j].squareState == 0 || squareArray[i,j].squareState == 1 || squareArray[i,j].squareState == 3 || squareArray[i,j].squareState == 4 || squareArray[i,j].squareState == 5){
					GameObject column = Instantiate(squareObject,transform.position,transform.rotation) as GameObject;
					squareArray[i,j].squareObject = column;
					column.transform.parent = GameObject.Find ("squarePanel").transform;
					column.name = "r"+i+"c" +j;
					//if state is set to 1 change the color
					if(squareArray[i,j].squareState == 1){ //if correct side
						column.transform.GetComponent<UnityEngine.UI.Image>().color = new Color32(240, 120, 48, 255);
					}
					else if(squareArray[i,j].squareState == 3){ //If cross
						column.transform.GetComponent<UnityEngine.UI.Image>().color = Color.red;
					}
					else if(squareArray[i,j].squareState == 4){ //If cross
						column.transform.GetComponent<UnityEngine.UI.Image>().color = Color.green;
					}
					else if(squareArray[i,j].squareState == 5){ //If cross
						column.transform.GetComponent<UnityEngine.UI.Image>().color = Color.yellow;
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

		//turnNumber = int.Parse(turnText.GetComponent<UnityEngine.UI.Text>().text);
		turnNumber++;

		if (turnTextLandscape) {
			turnTextLandscape.GetComponent<UnityEngine.UI.Text> ().text = turnNumber.ToString ();
		}
		if (turnTextPortrait) {
			turnTextPortrait.GetComponent<UnityEngine.UI.Text> ().text = turnNumber.ToString ();
		}


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
		if(clickedSquareState == 0 || clickedSquareState == 1 || clickedSquareState == 5 || clickedSquareState == 4){
			tempRow = row + 1;
			tempColumn = column -1;
			if(tempRow >= 0 && tempRow < fieldRows && tempColumn >=0 && tempColumn < fieldColumns){
				int squareState = CheckSquareState (tempRow,tempColumn); //Get the new square value
				if(squareArray[tempRow,tempColumn].squareObject && (squareState == 1 || squareState == 0 || squareState == 5)){
					squareArray[tempRow,tempColumn].squareObject.SendMessage("TurnSquare", squareState); //Turn the square with the new value
					numberOfTurns++;
				}
			}
		}
		//Square top middle
		if(clickedSquareState == 0 || clickedSquareState == 1 || clickedSquareState == 5 || clickedSquareState == 3){
			tempRow = row + 1;
			tempColumn = column;
			if(tempRow >= 0 && tempRow < fieldRows && tempColumn >=0 && tempColumn < fieldColumns){
				int squareState = CheckSquareState (tempRow,tempColumn); //Get the new square value
				if(squareArray[tempRow,tempColumn].squareObject && (squareState == 1 || squareState == 0 || squareState == 5)){
					squareArray[tempRow,tempColumn].squareObject.SendMessage("TurnSquare", squareState); //Turn the square with the new value
					numberOfTurns++;
				}
			}
		}
		//Square top right
		if(clickedSquareState == 0 || clickedSquareState == 1 || clickedSquareState == 5 || clickedSquareState == 4){
			tempRow = row + 1;
			tempColumn = column + 1;
			if(tempRow >= 0 && tempRow < fieldRows && tempColumn >=0 && tempColumn < fieldColumns){
				int squareState = CheckSquareState (tempRow,tempColumn); //Get the new square value
				if(squareArray[tempRow,tempColumn].squareObject && (squareState == 1 || squareState == 0 || squareState == 5)){
					squareArray[tempRow,tempColumn].squareObject.SendMessage("TurnSquare", squareState); //Turn the square with the new value
					numberOfTurns++;
				}
			}
		}
		//Middle ROw
		//Square middle left
		if (clickedSquareState == 0 || clickedSquareState == 1 || clickedSquareState == 5 || clickedSquareState == 3) {
			tempRow = row;
			tempColumn = column - 1;
			if (tempRow >= 0 && tempRow < fieldRows && tempColumn >= 0 && tempColumn < fieldColumns) {
				int squareState = CheckSquareState (tempRow, tempColumn); //Get the new square value
				if (squareArray [tempRow, tempColumn].squareObject && (squareState == 1 || squareState == 0 || squareState == 5)){
						squareArray [tempRow, tempColumn].squareObject.SendMessage ("TurnSquare", squareState); //Turn the square with the new value
						numberOfTurns++;
				}
			}
		}
		//Square middle middle
		if (clickedSquareState == 0 || clickedSquareState == 1 || clickedSquareState == 5 ) {
			tempRow = row;
			tempColumn = column;
			if(tempRow >= 0 && tempRow < fieldRows && tempColumn >=0 && tempColumn < fieldColumns){
				int squareState = CheckSquareState (tempRow,tempColumn ); //Get the new square value
				if(squareArray[tempRow,tempColumn].squareObject && (squareState == 1 || squareState == 0 || squareState == 5)){ 
					squareArray[tempRow,tempColumn].squareObject.SendMessage("TurnSquare", squareState); //Turn the square with the new value
					numberOfTurns++;
				}
			}
		}
		//Square middle right
		if (clickedSquareState == 0 || clickedSquareState == 1 || clickedSquareState == 5 || clickedSquareState == 3) {
			tempRow = row;
			tempColumn = column + 1;
			if (tempRow >= 0 && tempRow < fieldRows && tempColumn >= 0 && tempColumn < fieldColumns) {
					int squareState = CheckSquareState (tempRow, tempColumn); //Get the new square value
					if (squareArray [tempRow, tempColumn].squareObject && (squareState == 1 || squareState == 0 || squareState == 5)){
							squareArray [tempRow, tempColumn].squareObject.SendMessage ("TurnSquare", squareState); //Turn the square with the new value
							numberOfTurns++;
					}
			}
		}
		//Bottom ROw
		//Square bottom left
		if (clickedSquareState == 0 || clickedSquareState == 1 || clickedSquareState == 5 || clickedSquareState == 4) {
			tempRow = row - 1;
			tempColumn = column - 1;
			if (tempRow >= 0 && tempRow < fieldRows && tempColumn >= 0 && tempColumn < fieldColumns) {
					int squareState = CheckSquareState (tempRow, tempColumn); //Get the new square value
					if (squareArray [tempRow, tempColumn].squareObject && (squareState == 1 || squareState == 0 || squareState == 5)){
							squareArray [tempRow, tempColumn].squareObject.SendMessage ("TurnSquare", squareState); //Turn the square with the new value
							numberOfTurns++;
					}
			}
		}
		//Square bottom middle
		if (clickedSquareState == 0 || clickedSquareState == 1 || clickedSquareState == 5 || clickedSquareState == 3) {
			tempRow = row - 1;
			tempColumn = column;
			if (tempRow >= 0 && tempRow < fieldRows && tempColumn >= 0 && tempColumn < fieldColumns) {
					int squareState = CheckSquareState (tempRow, tempColumn); //Get the new square value
					if (squareArray [tempRow, tempColumn].squareObject && (squareState == 1 || squareState == 0  || squareState == 5)){
							squareArray [tempRow, tempColumn].squareObject.SendMessage ("TurnSquare", squareState); //Turn the square with the new value
							numberOfTurns++;
					}
			}
		}
		//Square bottom right
		if (clickedSquareState == 0 || clickedSquareState == 1 || clickedSquareState == 5 || clickedSquareState == 4) {
			tempRow = row - 1;
			tempColumn = column + 1;
			if (tempRow >= 0 && tempRow < fieldRows && tempColumn >= 0 && tempColumn < fieldColumns) {
					int squareState = CheckSquareState (tempRow, tempColumn); //Get the new square value
					if (squareArray [tempRow, tempColumn].squareObject && (squareState == 1 || squareState == 0  || squareState == 5)){
							squareArray [tempRow, tempColumn].squareObject.SendMessage ("TurnSquare", squareState); //Turn the square with the new value
							numberOfTurns++;
					}
			}
		}



		//Send statistic to  userstatistics.cs
		userStatistics.GetComponent<UserStatistics>().UpdateStatistic("Turns++",numberOfTurns);
		numberOfTurns = 0;

		int achievement10State = userStatistics.GetComponent<AchievementCollection>().GetLocalAchievementState (10);
		int achievement11State = userStatistics.GetComponent<AchievementCollection>().GetLocalAchievementState (11);
		int achievement12State = userStatistics.GetComponent<AchievementCollection>().GetLocalAchievementState (12);

		//Check achievements
		int totalNumberOfTurns = PlayerPrefs.GetInt ("TotalNumberOfTurns");
		if(achievement10State<1) //If achievement is not unlocked...
		{
			if(totalNumberOfTurns>=200) //.. check if achievement condition is met
			{
				Debug.Log ("Execute Achievement 10");
				userStatistics.GetComponent<AchievementCollection>().SetLocalAchievementState (10,1);
				PlayerPrefs.SetInt ("NewAchievement", 1); //Set the newAchievement playerPref always after setting the achievementStates

			}
		}
		else if(achievement11State<1)
		{
			if(totalNumberOfTurns>=1000)
			{
				Debug.Log ("Execute Achievement 11");
				userStatistics.GetComponent<AchievementCollection>().SetLocalAchievementState (11,1);
				PlayerPrefs.SetInt ("NewAchievement", 1);

			}
		}
		else if(achievement12State<1)
		{
			if(totalNumberOfTurns>=5000)
			{
				userStatistics.GetComponent<AchievementCollection>().SetLocalAchievementState (12,1);
				PlayerPrefs.SetInt ("NewAchievement", 1);

			}
		}

		//Call the achievement check function
		achievementPanel.GetComponent<CheckForAchievements> ().CheckAchievements ();

		//Check if won
		CheckIfWon();
	}

	//Checks the state of the square and change it accordingly
	int CheckSquareState(int row, int column){
		if(squareArray[row,column].squareState == 0){
			squareArray[row,column].SetSquareState(1);
		}else if(squareArray[row,column].squareState == 1){
			squareArray[row,column].SetSquareState(0);
		}else if(squareArray[row,column].squareState == 5){
			squareArray[row,column].SetSquareState(0);
		}
		return squareArray[row,column].squareState;
	}


	//Check everyturn if the player has won
	void CheckIfWon(){
		playerWon = true;
		int chosenLevel = PlayerPrefs.GetInt ("ChosenLevel");

		if (chosenLevel < 300) { //Everything under 300 are normal lavels. 4xx are form levels
				for (int i = 0; i < fieldRows; i++) {
						for (int j = 0; j < fieldColumns; j++) {	
								if (squareArray [i, j].squareState == 0 || squareArray [i, j].squareState == 5) {
										playerWon = false;
								}
						}
				}
		}

		if(playerWon){
			//If a new level has been solved, save this value into a prefab
			if(PlayerPrefs.GetInt ("StarsLevel" + chosenLevel) == 0)
			{
				int completedLevels = PlayerPrefs.GetInt ("NumberOfCompletedLevels") + 1;
				PlayerPrefs.SetInt ("NumberOfCompletedLevels", completedLevels);

				//Check for reached achievements
				if(completedLevels == 5)
				{
					userStatistics.GetComponent<AchievementCollection>().SetLocalAchievementState (6,1);
					PlayerPrefs.SetInt ("NewAchievement", 1);
					achievementPanel.GetComponent<CheckForAchievements> ().CheckAchievements ();
				}
				else if(completedLevels==20)
				{
					userStatistics.GetComponent<AchievementCollection>().SetLocalAchievementState (7,1);
					PlayerPrefs.SetInt ("NewAchievement", 1);
					achievementPanel.GetComponent<CheckForAchievements> ().CheckAchievements ();
				}
				else if(completedLevels==40)
				{
					userStatistics.GetComponent<AchievementCollection>().SetLocalAchievementState (8,1);
					PlayerPrefs.SetInt ("NewAchievement", 1);
					achievementPanel.GetComponent<CheckForAchievements> ().CheckAchievements ();
				}
				else if(completedLevels==72)
				{
					userStatistics.GetComponent<AchievementCollection>().SetLocalAchievementState (9,1);
					PlayerPrefs.SetInt ("NewAchievement", 1);
					achievementPanel.GetComponent<CheckForAchievements> ().CheckAchievements ();
				}
			}
			//Store the statistics in Prefabs (Script: UserStatistics)
			//userStatistics.SendMessage ("StoreStatistics");
			StartCoroutine(EnableEndPanel());
		}
	}

	IEnumerator EnableEndPanel()
	{
		yield return new WaitForSeconds (0.5f);
		gameEndPanel.SetActive (true);
		GameObject childPanel = gameEndPanel.transform.FindChild("GameEndPanel").gameObject;
		childPanel.GetComponent<Animation>().Play ();

		//Set the number of turns
		string turnText;
		if (turnNumber > 1) {
			turnText = turnNumber + " turns";
		} else {
			turnText = turnNumber + " turn";
		}
		childPanel.transform.FindChild ("TurnText").GetComponent<UnityEngine.UI.Text> ().text = turnText;

		GetNumberOfTrees ();
	}


	//When user tries to turn a square (TurnScript), it checks if the game is already won, by accessing this function
	public bool ReturnWinningState(){
		return playerWon;
	}

	//Get the number of achieved trees, based on the number of turns
	void GetNumberOfTrees()
	{
		int numberOfTrees;
		int levelNumber = PlayerPrefs.GetInt ("ChosenLevel");
		numberOfTrees = userStatistics.GetComponent<TreeTable> ().GetNumberOfTrees (levelNumber, turnNumber); //Call the function Get number of trees transmitting the levelnumber and the number of turns needed


		string prefabName = "StarsLevel" + levelNumber;
		int playerPrefValue = PlayerPrefs.GetInt (prefabName);
		if(numberOfTrees > playerPrefValue)
		{
			PlayerPrefs.SetInt (prefabName, numberOfTrees);
			//If reached 3 stars for the first time, update to the playerprefs
			if(numberOfTrees == 3)
			{
				int newPerfectValue = PlayerPrefs.GetInt ("PerfectedLevels") + 1;
				PlayerPrefs.SetInt ("PerfectedLevels", newPerfectValue);
			}
		}



		//Add number of stars to statistic

		if (playerPrefValue < numberOfTrees)
		{
			int difference = numberOfTrees - playerPrefValue;
			if(levelNumber >= 100 && levelNumber < 200)
			{
				int newStarValue = PlayerPrefs.GetInt("Category1Stars") + difference;
				PlayerPrefs.SetInt ("Category1Stars", newStarValue);
			}
			else if(levelNumber >= 200 && levelNumber < 300)
			{
				int newStarValue = PlayerPrefs.GetInt("Category2Stars") + difference;
				PlayerPrefs.SetInt ("Category2Stars", newStarValue);
			}
			else if(levelNumber >= 300 && levelNumber < 400)
			{
				int newStarValue = PlayerPrefs.GetInt("Category3Stars") + difference;
				PlayerPrefs.SetInt ("Category3Stars", newStarValue);
			}
			else
			{
				Debug.Log ("Levelnummer nicht vorhanden!");
			}
		}

		//Get the tree objects
		GameObject tree1 = treeContainer.transform.FindChild ("Tree1").gameObject;
		GameObject tree2 = treeContainer.transform.FindChild ("Tree2").gameObject;
		GameObject tree3 = treeContainer.transform.FindChild ("Tree3").gameObject;

		//Set the tree objects
		tree1.GetComponent<Image>().color = Color.yellow;
		if(numberOfTrees > 1)
		{
			tree2.GetComponent<Image>().color = Color.yellow;
		}

		if (numberOfTrees > 2) 
		{
			tree3.GetComponent<Image> ().color = Color.yellow;
		}

	}



	
}
