using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using TMPro;

public class GameLogic : MonoBehaviour
{

    //--------------Variables----------------
    int fieldRows;
    int fieldColumns;
    float squareSpace = Screen.width / 12.3f; //The spacing between the squares  --> otherwise 120 //before 13.3 -> /14 
    float squareSize = Screen.width / 13; //before 13.3 -> /15
    int turnNumber;

    public GameObject squareObject;
    public TextMeshProUGUI turnTextPortrait;
    public bool playerWon = false;
    LevelScript levelScript;
    private GameObject userStatistics;
    private int numberOfTurns; //To count how many squares have been turned --> for statistics

    public GameObject gameEndPanelPortrait;
    public GameObject achievementPanel;

    public GameObject starOne;
    public GameObject starsTwo;
    public GameObject starsThree;
    public UnityEngine.UI.Text gameEndTurnsObject;

    public Material backsideMaterial;
    public Material backsideMaterialYellow;

    private LevelStatistics levelStatistics;

    //Variables to store achievement prefabs
    //The prefab values are stored in this variables (in the start function), because they have to be checked with every move.
    //Getting prefabs costs more than just checking a variable


    //-----------------CLASSES---------------
    public class cSquareClass
    {
        public GameObject squareObject;
        public int squareState = 0; //States: 0 = wrongSide (blue), 1 = rightSide (orange), 2 = noSquare/wall, 3 = crossTurn (red), 4 = edgeTurn (green), 5 = Yellow

        public int GetSquareState()
        {
            return squareState;
        }

        public void SetSquareState(int newState)
        {
            squareState = newState;
        }
    }

    //----------------CLASS Object----------
    cSquareClass[,] squareArray;

    //-------------------------START--------------------------------
    void Start()
    {
        userStatistics = GameObject.Find("UserStatistics");

        levelScript = GameObject.Find("LevelScript").GetComponent<LevelScript>();
        levelStatistics = LevelStatistics.GetInstance();

        //Get Rows and Columns
        fieldRows = levelScript.rows;
        fieldColumns = levelScript.columns;

        InitializeArray(fieldRows, fieldColumns); //Initializes the array
        PrepareField(); //Prepares the field with the buttons
    }


    //-------------FUNCTIONS-------------------------------
    void InitializeArray(int rows, int columns)
    {
        squareArray = new cSquareClass[rows, columns];

        //Initialize the Array
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < columns; j++)
            {
                squareArray[i, j] = new cSquareClass();
            }
        }
    }

    //Set all the fields
    void PrepareField()
    {

        bool evenNumberWidth = false;
        bool evenNumberHeight = false;

        //If mode == portrait, set the square size depending on the height
        if (Screen.height > Screen.width)
        {
            //squareSpace = Screen.height / 12.3f; //The spacing between the squares  --> otherwise 120 //before 13.3 -> /14 
            squareSpace = 1.15f;
            squareSize = Screen.height / 13; //before 13.3 -> /15
        }


        //Check if Width and Height is even
        if (fieldRows % 2 == 0)
        {
            evenNumberHeight = true;
        }
        if (fieldColumns % 2 == 0)
        {
            evenNumberWidth = true;
        }

        //Create Field Rows
        for (int i = 0; i < fieldRows; i++)
        {
            float yPosition; //Stores the height of the square
            if (evenNumberHeight)
            {
                float halfField = fieldRows / 2;
                float difference = halfField - i;
                yPosition = -difference * squareSpace + squareSpace / 2;
            }
            else
            {
                float halfField = fieldRows / 2;
                float difference = halfField - i;
                yPosition = -difference * squareSpace;
            }


            //Create the field columns
            for (int j = 0; j < fieldColumns; j++)
            {
                //GET THE VALUES FROM THE LEVEL
                var square = squareArray[i, j];
                square.squareState = levelScript.fieldStructureArray[i, j];
                //Debug.Log (squareArray[i,j].squareState);
                //Create the square
                if (square.squareState == 0 || square.squareState == 1 || square.squareState == 3 || square.squareState == 4 || square.squareState == 5)
                {
                    GameObject column = Instantiate(squareObject, transform.position, transform.rotation) as GameObject;
                    square.squareObject = column;
                    column.transform.parent = GameObject.Find("squarePanel").transform;
                    column.name = "r" + i + "c" + j;
                    //if state is set to 1 change the color
                    if (square.squareState == 1)
                    { //if correct side
                        column.transform.eulerAngles = new Vector3(0, 0, 0); //column.transform.GetComponent<UnityEngine.UI.Image>().color = new Color32(240, 120, 48, 255);
                    }
                    else if (square.squareState == 3)
                    { //If cross
                        column.transform.GetComponent<UnityEngine.UI.Image>().color = Color.red;
                    }
                    else if (square.squareState == 4)
                    { //If cross
                        column.transform.GetComponent<UnityEngine.UI.Image>().color = Color.green;
                    }
                    else if (square.squareState == 5)
                    { //If cross
                        column.transform.eulerAngles = new Vector3(0, 180, 0); //column.transform.GetComponent<UnityEngine.UI.Image>().color = new Color32(255, 226, 32, 255);
                        square.squareObject.transform.Find("backSide").GetComponent<Renderer>().material = backsideMaterialYellow;
                    }
                    //Set position regarding width count
                    if (evenNumberWidth)
                    {
                        float halfField = fieldColumns / 2;
                        float difference = halfField - j;
                        column.transform.position = new Vector2(-difference * squareSpace + squareSpace / 2, yPosition);
                        //Debug.Log (i + "," + j+ "   X: " + (-difference * squareSpace + squareSpace/2) + " Y: " + yPosition);
                    }
                    else
                    {
                        float halfField = fieldColumns / 2;
                        float difference = halfField - j;
                        column.transform.position = new Vector2(-difference * squareSpace, yPosition);
                        //Debug.Log (i + "," + j+ "   X: " + (-difference * squareSpace) + " Y: " + yPosition);
                    }

                    //Set size of the square
                    //column.GetComponent<RectTransform>().sizeDelta = new Vector2(squareSize, squareSize);
                }
            }

        }
    }



    //Turn the squares around the klicked square
    public void TurnOtherSquares(string squareName)
    {
        turnNumber++;

        if (turnTextPortrait)
        {
            turnTextPortrait.text = turnNumber.ToString();
        }


        //Variables

        int tempRow;
        int tempColumn;
        int row = int.Parse(squareName.Substring(1, 1)); //Get the second letter of the word and convert to string
        int column = int.Parse(squareName.Substring(3, 1)); //Get the fourth letter of the word and convert to string

        //Get the value of the clicked square
        int clickedSquareState = squareArray[row, column].squareState;

        //TopRow
        //Square top left
        if (clickedSquareState == 0 || clickedSquareState == 1 || clickedSquareState == 5 || clickedSquareState == 4)
        {
            tempRow = row + 1;
            tempColumn = column - 1;
            if (tempRow >= 0 && tempRow < fieldRows && tempColumn >= 0 && tempColumn < fieldColumns)
            {
                int squareState = CheckSquareState(tempRow, tempColumn); //Get the new square value
                if (squareArray[tempRow, tempColumn].squareObject && (squareState == 1 || squareState == 0 || squareState == 5))
                {
                    squareArray[tempRow, tempColumn].squareObject.SendMessage("TurnSquare", squareState); //Turn the square with the new value
                    numberOfTurns++;
                }
            }
        }
        //Square top middle
        if (clickedSquareState == 0 || clickedSquareState == 1 || clickedSquareState == 5 || clickedSquareState == 3)
        {
            tempRow = row + 1;
            tempColumn = column;
            if (tempRow >= 0 && tempRow < fieldRows && tempColumn >= 0 && tempColumn < fieldColumns)
            {
                int squareState = CheckSquareState(tempRow, tempColumn); //Get the new square value
                if (squareArray[tempRow, tempColumn].squareObject && (squareState == 1 || squareState == 0 || squareState == 5))
                {
                    squareArray[tempRow, tempColumn].squareObject.SendMessage("TurnSquare", squareState); //Turn the square with the new value
                    numberOfTurns++;
                }
            }
        }
        //Square top right
        if (clickedSquareState == 0 || clickedSquareState == 1 || clickedSquareState == 5 || clickedSquareState == 4)
        {
            tempRow = row + 1;
            tempColumn = column + 1;
            if (tempRow >= 0 && tempRow < fieldRows && tempColumn >= 0 && tempColumn < fieldColumns)
            {
                int squareState = CheckSquareState(tempRow, tempColumn); //Get the new square value
                if (squareArray[tempRow, tempColumn].squareObject && (squareState == 1 || squareState == 0 || squareState == 5))
                {
                    squareArray[tempRow, tempColumn].squareObject.SendMessage("TurnSquare", squareState); //Turn the square with the new value
                    numberOfTurns++;
                }
            }
        }
        //Middle ROw
        //Square middle left
        if (clickedSquareState == 0 || clickedSquareState == 1 || clickedSquareState == 5 || clickedSquareState == 3)
        {
            tempRow = row;
            tempColumn = column - 1;
            if (tempRow >= 0 && tempRow < fieldRows && tempColumn >= 0 && tempColumn < fieldColumns)
            {
                int squareState = CheckSquareState(tempRow, tempColumn); //Get the new square value
                if (squareArray[tempRow, tempColumn].squareObject && (squareState == 1 || squareState == 0 || squareState == 5))
                {
                    squareArray[tempRow, tempColumn].squareObject.SendMessage("TurnSquare", squareState); //Turn the square with the new value
                    numberOfTurns++;
                }
            }
        }
        //Square middle middle
        if (clickedSquareState == 0 || clickedSquareState == 1 || clickedSquareState == 5)
        {
            tempRow = row;
            tempColumn = column;
            if (tempRow >= 0 && tempRow < fieldRows && tempColumn >= 0 && tempColumn < fieldColumns)
            {
                int squareState = CheckSquareState(tempRow, tempColumn); //Get the new square value
                if (squareArray[tempRow, tempColumn].squareObject && (squareState == 1 || squareState == 0 || squareState == 5))
                {
                    squareArray[tempRow, tempColumn].squareObject.SendMessage("TurnSquare", squareState); //Turn the square with the new value
                    numberOfTurns++;
                }
            }
        }
        //Square middle right
        if (clickedSquareState == 0 || clickedSquareState == 1 || clickedSquareState == 5 || clickedSquareState == 3)
        {
            tempRow = row;
            tempColumn = column + 1;
            if (tempRow >= 0 && tempRow < fieldRows && tempColumn >= 0 && tempColumn < fieldColumns)
            {
                int squareState = CheckSquareState(tempRow, tempColumn); //Get the new square value
                if (squareArray[tempRow, tempColumn].squareObject && (squareState == 1 || squareState == 0 || squareState == 5))
                {
                    squareArray[tempRow, tempColumn].squareObject.SendMessage("TurnSquare", squareState); //Turn the square with the new value
                    numberOfTurns++;
                }
            }
        }
        //Bottom ROw
        //Square bottom left
        if (clickedSquareState == 0 || clickedSquareState == 1 || clickedSquareState == 5 || clickedSquareState == 4)
        {
            tempRow = row - 1;
            tempColumn = column - 1;
            if (tempRow >= 0 && tempRow < fieldRows && tempColumn >= 0 && tempColumn < fieldColumns)
            {
                int squareState = CheckSquareState(tempRow, tempColumn); //Get the new square value
                if (squareArray[tempRow, tempColumn].squareObject && (squareState == 1 || squareState == 0 || squareState == 5))
                {
                    squareArray[tempRow, tempColumn].squareObject.SendMessage("TurnSquare", squareState); //Turn the square with the new value
                    numberOfTurns++;
                }
            }
        }
        //Square bottom middle
        if (clickedSquareState == 0 || clickedSquareState == 1 || clickedSquareState == 5 || clickedSquareState == 3)
        {
            tempRow = row - 1;
            tempColumn = column;
            if (tempRow >= 0 && tempRow < fieldRows && tempColumn >= 0 && tempColumn < fieldColumns)
            {
                int squareState = CheckSquareState(tempRow, tempColumn); //Get the new square value
                if (squareArray[tempRow, tempColumn].squareObject && (squareState == 1 || squareState == 0 || squareState == 5))
                {
                    squareArray[tempRow, tempColumn].squareObject.SendMessage("TurnSquare", squareState); //Turn the square with the new value
                    numberOfTurns++;
                }
            }
        }
        //Square bottom right
        if (clickedSquareState == 0 || clickedSquareState == 1 || clickedSquareState == 5 || clickedSquareState == 4)
        {
            tempRow = row - 1;
            tempColumn = column + 1;
            if (tempRow >= 0 && tempRow < fieldRows && tempColumn >= 0 && tempColumn < fieldColumns)
            {
                int squareState = CheckSquareState(tempRow, tempColumn); //Get the new square value
                if (squareArray[tempRow, tempColumn].squareObject && (squareState == 1 || squareState == 0 || squareState == 5))
                {
                    squareArray[tempRow, tempColumn].squareObject.SendMessage("TurnSquare", squareState); //Turn the square with the new value
                    numberOfTurns++;
                }
            }
        }

        //Send statistic to  userstatistics.cs
        userStatistics.GetComponent<UserStatistics>().UpdateStatistic("Turns++", numberOfTurns);
        AchievementCollection achievementCollection = userStatistics.GetComponent<AchievementCollection>();
        numberOfTurns = 0;

        int achievement10State = achievementCollection.GetLocalAchievementState(10);
        int achievement11State = achievementCollection.GetLocalAchievementState(11);
        int achievement12State = achievementCollection.GetLocalAchievementState(12);

        //Check achievements
        int totalNumberOfTurns = PlayerPrefs.GetInt("TotalNumberOfTurns");
        if (achievement10State < 1) //If achievement is not unlocked...
        {
            if (totalNumberOfTurns >= 200) //.. check if achievement condition is met
            {
                Debug.Log("Execute Achievement 10");
                GooglePlayAchievements.UnlockAchiemevent(GooglePlayAchievements.A13_TURNAROUND);
                achievementCollection.CompleteGlobalAchievement(10);
            }
        }
        else if (achievement11State < 1)
        {
            if (totalNumberOfTurns >= 1000)
            {
                Debug.Log("Execute Achievement 11");
                GooglePlayAchievements.UnlockAchiemevent(GooglePlayAchievements.A14_TURNING_TABLES);
                achievementCollection.CompleteGlobalAchievement(11);

            }
        }
        else if (achievement12State < 1)
        {
            if (totalNumberOfTurns >= 5000)
            {
                GooglePlayAchievements.UnlockAchiemevent(GooglePlayAchievements.A15_FLIPPING_NINJA);
                achievementCollection.CompleteGlobalAchievement(12);
            }
        }

        //Check if won
        CheckIfWon();
    }

    //Checks the state of the square and change it accordingly
    int CheckSquareState(int row, int column)
    {
        var square = squareArray[row, column];
        if (square.squareState == 0)
        {
            square.SetSquareState(1);
        }
        else if (square.squareState == 1)
        {
            square.SetSquareState(0);
        }
        else if (square.squareState == 5)
        {
            square.SetSquareState(0);
            StartCoroutine(ChangeBacksideColor(square.squareObject));
        }
        return square.squareState;
    }

    IEnumerator ChangeBacksideColor(GameObject square)
    {
        yield return new WaitForSeconds(0.5f);
        square.transform.Find("backSide").GetComponent<Renderer>().material = backsideMaterial;
    }


    //Check everyturn if the player has won
    void CheckIfWon()
    {
        playerWon = true;
        int chosenLevel = PlayerPrefs.GetInt("ChosenLevel");

        for (int i = 0; i < fieldRows; i++)
        {
            for (int j = 0; j < fieldColumns; j++)
            {
                if (squareArray[i, j].squareState == 0 || squareArray[i, j].squareState == 5)
                {
                    playerWon = false;
                }
            }
        }


        if (playerWon)
        {
            AchievementCollection achievementCollection = userStatistics.GetComponent<AchievementCollection>();
            //If a new level has been solved, save this value into a prefab
            int category = chosenLevel / 100;
            int levelNumber = chosenLevel - category*100;
            int numberOfStarsInPrefab = levelStatistics.GetNumberOfStars(category, levelNumber);
            if (numberOfStarsInPrefab == 0)
            {
                levelStatistics.AddCompletedLevel(category);
                int completedLevels = levelStatistics.GetTotalCompletedLevels();

                //Check for reached achievements
                if (completedLevels == 5)
                {
                    GooglePlayAchievements.UnlockAchiemevent(GooglePlayAchievements.A9_FIRST_STEPS);
                    achievementCollection.CompleteGlobalAchievement(6);
                }
                else if (completedLevels == 20)
                {
                    GooglePlayAchievements.UnlockAchiemevent(GooglePlayAchievements.A10_AMATEUR);
                    achievementCollection.CompleteGlobalAchievement(7);
                }
                else if (completedLevels == 40)
                {
                    GooglePlayAchievements.UnlockAchiemevent(GooglePlayAchievements.A11_CHALLENGER);
                    achievementCollection.CompleteGlobalAchievement(8);
                }
                else if (completedLevels == 72)
                {
                    GooglePlayAchievements.UnlockAchiemevent(GooglePlayAchievements.A12_BLACKBELT);
                    achievementCollection.CompleteGlobalAchievement(9);
                }
            }
            //Store the statistics in Prefabs (Script: UserStatistics)
            //userStatistics.SendMessage ("StoreStatistics");
            StartCoroutine(EndingAnimation());
            StartCoroutine(EnableEndPanel(fieldRows * 0.3f + 1.5f));
        }
    }

    IEnumerator EndingAnimation()
    {
        yield return new WaitForSeconds(0.5f);
        for(int x = 0; x < fieldColumns; x++)
        {
            for (int y = 0; y < fieldRows; y++)
            {
                cSquareClass square = squareArray[y, x];
                if(square != null && square.squareObject != null)
                {
                    square.squareObject.GetComponent<Animation>().Play("turn360");
                }
            }
            yield return new WaitForSeconds(0.12f);
        }
    }

    IEnumerator EnableEndPanel(float waitTime)
    {
        yield return new WaitForSeconds(waitTime);
        gameEndPanelPortrait.SetActive(true);
        gameEndTurnsObject.text = turnNumber.ToString();

        GetNumberOfTrees();
    }


    //When user tries to turn a square (TurnScript), it checks if the game is already won, by accessing this function
    public bool ReturnWinningState()
    {
        return playerWon;
    }

    //Get the number of achieved trees, based on the number of turns
    void GetNumberOfTrees()
    {
        int numberOfTrees;
        int levelNumber = PlayerPrefs.GetInt("ChosenLevel");
        numberOfTrees = userStatistics.GetComponent<TreeTable>().GetNumberOfTrees(levelNumber, turnNumber); //Call the function Get number of trees transmitting the levelnumber and the number of turns needed


        int category = levelNumber / 100;
        int levelNumberShort = levelNumber - category * 100;
        int numberOfStarsInPrefab = levelStatistics.GetNumberOfStars(category, levelNumberShort);
        if (numberOfTrees > numberOfStarsInPrefab)
        {
            levelStatistics.UpdateLocalAndPrefabStarValue(category, levelNumberShort, numberOfTrees);
            //If reached 3 stars for the first time, update to the playerprefs
            if (numberOfTrees == 3)
            {
                int newPerfectValue = PlayerPrefs.GetInt("PerfectedLevels") + 1;
                PlayerPrefs.SetInt("PerfectedLevels", newPerfectValue);
            }
        }

        //Add number of stars to statistic

        if (numberOfStarsInPrefab < numberOfTrees)
        {
            int difference = numberOfTrees - numberOfStarsInPrefab;
            if (levelNumber >= 100 && levelNumber < 200)
            {
                int newStarValue = PlayerPrefs.GetInt("Category1Stars") + difference;
                PlayerPrefs.SetInt("Category1Stars", newStarValue);
            }
            else if (levelNumber >= 200 && levelNumber < 300)
            {
                int newStarValue = PlayerPrefs.GetInt("Category2Stars") + difference;
                PlayerPrefs.SetInt("Category2Stars", newStarValue);
            }
            else if (levelNumber >= 300 && levelNumber < 400)
            {
                int newStarValue = PlayerPrefs.GetInt("Category3Stars") + difference;
                PlayerPrefs.SetInt("Category3Stars", newStarValue);
            }
            else if (levelNumber >= 400 && levelNumber < 500)
            {
                int newStarValue = PlayerPrefs.GetInt("Category4Stars") + difference;
                PlayerPrefs.SetInt("Category4Stars", newStarValue);
            }
            else
            {
                Debug.Log("Levelnummer nicht vorhanden!");
            }
        }


        //Enable the correct stars object
        if (numberOfTrees > 2)
        {
            starsThree.SetActive(true);
        }
        else if (numberOfTrees > 1)
        {
            starsTwo.SetActive(true);
        }
        else
        {
            starOne.SetActive(true);
        }
    }

}
