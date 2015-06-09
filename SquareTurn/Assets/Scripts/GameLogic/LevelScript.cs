using UnityEngine;
using System.Collections;

public class LevelScript : MonoBehaviour {

	public int[,] fieldStructureArray; //Defines the field
	public int rows;
	public int columns;
	public GameObject gameManagerObject;


	void Awake(){
		int chosenLevel = PlayerPrefs.GetInt ("ChosenLevel");
		DefineField(chosenLevel); // Put the arraynumber in the brackets
	}

	//----------------LEVELS------------------
	void DefineField(int level){
		

		//////LEVEL 100 - 199/----------------------------------------------------

		if (level == 100) {
			InitializeArraySize (3, 3);
		}

		if (level == 101) {
			InitializeArraySize (3, 3);
			fieldStructureArray [0, 0] = 2;
			fieldStructureArray [1, 1] = 2;
			fieldStructureArray [2, 2] = 2;
		}

		if (level == 102) {
			InitializeArraySize (3, 3);
			fieldStructureArray [1, 0] = 2;
			fieldStructureArray [1, 1] = 2;
			fieldStructureArray [1, 2] = 2;
		}

		if (level == 103) {
			InitializeArraySize (4, 4);
		}

		if (level == 104) {
			InitializeArraySize (4, 4);
			fieldStructureArray[1,0] = 2;
		}

		if (level == 105) {
			InitializeArraySize (4, 4);
			fieldStructureArray [0, 0] = 2;
			fieldStructureArray [1, 0] = 2;
		}

		if (level == 106) {
			InitializeArraySize (4, 4);
			fieldStructureArray [0, 0] = 2;
			fieldStructureArray [1, 1] = 2;
		}

		if (level == 107) {
			InitializeArraySize (4, 4);
			fieldStructureArray [0, 0] = 2;
			fieldStructureArray [1, 0] = 2;
			fieldStructureArray [2, 3] = 2;
			fieldStructureArray [3, 3] = 2;
		}

		if (level == 108) {
			InitializeArraySize (5, 5);
		}

		if (level == 109) {
			InitializeArraySize (5, 5);
			fieldStructureArray [0, 0] = 2;
			fieldStructureArray [4, 4] = 2;
		}

		if (level == 110) {
			InitializeArraySize (5, 5);
			fieldStructureArray [0, 0] = 2;
			fieldStructureArray [0, 1] = 2;
			fieldStructureArray [0, 3] = 2;
			fieldStructureArray [0, 4] = 2;
			fieldStructureArray [1, 0] = 2;
			fieldStructureArray [1, 4] = 2;
			fieldStructureArray [2, 0] = 2;
			fieldStructureArray [2, 4] = 2;
			fieldStructureArray [3, 0] = 2;
			fieldStructureArray [3, 4] = 2;
			fieldStructureArray [4, 0] = 2;
			fieldStructureArray [4, 1] = 2;
			fieldStructureArray [4, 3] = 2;
			fieldStructureArray [4, 4] = 2;
		}

		if (level == 111) {
			InitializeArraySize (5, 5);
			fieldStructureArray [0, 2] = 2;
			fieldStructureArray [2, 0] = 2;
			fieldStructureArray [2, 4] = 2;
			fieldStructureArray [4, 2] = 2;
		}

		if (level == 112) {
			InitializeArraySize (6, 6);
			fieldStructureArray [0, 0] = 2;
			fieldStructureArray [0, 1] = 2;
			fieldStructureArray [0, 4] = 2;
			fieldStructureArray [0, 5] = 2;
			fieldStructureArray [1, 0] = 2;
			fieldStructureArray [1, 5] = 2;
			fieldStructureArray [4, 0] = 2;
			fieldStructureArray [4, 5] = 2;
			fieldStructureArray [5, 0] = 2;
			fieldStructureArray [5, 1] = 2;
			fieldStructureArray [5, 4] = 2;
			fieldStructureArray [5, 5] = 2;
		}

		if (level == 113) {
			InitializeArraySize (3, 3);
			fieldStructureArray [0, 0] = 2;
			fieldStructureArray [1, 1] = 2;
		}

		if (level == 114) {
			InitializeArraySize (3, 3);
			fieldStructureArray [0, 0] = 2;
			fieldStructureArray [1, 0] = 2;
			fieldStructureArray [1, 1] = 2;
		}

		if (level == 115) {
			InitializeArraySize (4, 4);
			fieldStructureArray [0, 0] = 2;
			fieldStructureArray [3, 0] = 2;
			fieldStructureArray [3, 3] = 2;
		}

		if (level == 116) {
			InitializeArraySize (4, 4);
			fieldStructureArray [0, 0] = 2;
			fieldStructureArray [3, 3] = 2;
		}

		if (level == 117) {
			InitializeArraySize (5, 5);
			fieldStructureArray [0, 0] = 2;
			fieldStructureArray [0, 4] = 2;
			fieldStructureArray [4, 0] = 2;
			fieldStructureArray [4, 4] = 2;
		}

		if (level == 118) {
			InitializeArraySize (5, 5);
			fieldStructureArray [0, 0] = 2;
			fieldStructureArray [0, 1] = 2;
			fieldStructureArray [0, 2] = 2;
			fieldStructureArray [0, 4] = 2;
			fieldStructureArray [1, 0] = 2;
			fieldStructureArray [2, 0] = 2;
			fieldStructureArray [4, 0] = 2;
			fieldStructureArray [4, 2] = 2;
			fieldStructureArray [4, 3] = 2;
			fieldStructureArray [4, 4] = 2;
		}

		if (level == 119) {
			InitializeArraySize (5, 5);
			fieldStructureArray [0, 0] = 2;
			fieldStructureArray [1, 1] = 2;
			fieldStructureArray [2, 2] = 2;
			fieldStructureArray [3, 3] = 2;
			fieldStructureArray [4, 4] = 2;
		}

		if (level == 120) {
			InitializeArraySize (5, 5);
			fieldStructureArray [0, 0] = 2;
			fieldStructureArray [1, 1] = 2;
			fieldStructureArray [2, 1] = 2;
			fieldStructureArray [3, 1] = 2;
			fieldStructureArray [4, 0] = 2;
		}

		if (level == 121) {
			InitializeArraySize (3, 3);
			fieldStructureArray [1, 1] = 2;

		}

		if (level == 122) {
			InitializeArraySize (4, 4);
			fieldStructureArray [0, 0] = 2;
			fieldStructureArray [1, 0] = 2;
			fieldStructureArray [3, 0] = 2;
			fieldStructureArray [3, 2] = 2;
			fieldStructureArray [3, 3] = 2;
		}

		if (level == 123) {
			InitializeArraySize (5, 5);
			fieldStructureArray [0, 0] = 2;
			fieldStructureArray [0, 1] = 2;
			fieldStructureArray [0, 2] = 2;
			fieldStructureArray [0, 4] = 2;
			fieldStructureArray [1, 0] = 2;
			fieldStructureArray [3, 0] = 2;
			fieldStructureArray [3, 2] = 2;
			fieldStructureArray [3, 3] = 2;
		}




		//////////////////////////ENDE 100 - 199 ////////////////////////////////


		//Set gameManager active to start the level creation
		gameManagerObject.SetActive (true);
	}


	void InitializeArraySize(int tempRows, int tempColumns){
		//Set rows and Column size
		rows = tempRows;
		columns = tempColumns;

		//Initialize the Array
		fieldStructureArray = new int[rows,columns];

		for(int i = 0; i < rows; i++)
		{
			for(int j = 0; j < columns; j++)
			{	
				fieldStructureArray[i,j] = new int();
			}
		}
			

		for(int i = 0; i < rows; i++)
		{
			for(int j = 0; j < columns; j++)
			{	
				fieldStructureArray[i,j] = 0;
			}
		}
	}
	
}
