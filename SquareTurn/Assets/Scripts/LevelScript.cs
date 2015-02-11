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

		if (level == 1) {
				//Initialize the Array and set every value to 0
				InitializeArraySize (3, 3);
				//Define the extras
		} else if (level == 2) {
				//Initialize the Array and set every value to 0
				InitializeArraySize (3, 6);
				//Define the extras
		} else if (level == 3) {
			//Initialize the Array and set every value to 0
			InitializeArraySize (3, 6);
			//Define the extras
			fieldStructureArray[0,0] = 1;
			fieldStructureArray[0,1] = 1;

			fieldStructureArray[1,0] = 1;
			fieldStructureArray[1,1] = 1;

			fieldStructureArray[2,0] = 1;
			fieldStructureArray[2,1] = 1;
		}

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
