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


		//////LEVEL 200 - 299/----------------------------------------------------
		if (level == 200) {
			InitializeArraySize (3, 3);
			fieldStructureArray [0, 1] = 5;
			fieldStructureArray [1, 1] = 5;
			fieldStructureArray [2, 1] = 5;
		}

		if (level == 201) {
			InitializeArraySize (3, 3);
			fieldStructureArray [0, 0] = 5;
			fieldStructureArray [1, 0] = 5;
			fieldStructureArray [2, 0] = 5;
			fieldStructureArray [2, 1] = 5;
			fieldStructureArray [2, 2] = 5;
		}

		if (level == 202) {
			InitializeArraySize (3, 3);
			fieldStructureArray [0, 0] = 2;
			fieldStructureArray [1, 0] = 5;
		}

		if (level == 203) {
			InitializeArraySize (4, 4);
			fieldStructureArray [0, 0] = 2;
			fieldStructureArray [1, 1] = 5;
			fieldStructureArray [1, 2] = 5;
			fieldStructureArray [2, 1] = 5;
			fieldStructureArray [2, 2] = 5;
			fieldStructureArray [3, 3] = 2;
		}

		if (level == 204) {
			InitializeArraySize (5, 5);
			fieldStructureArray [1, 1] = 5;
			fieldStructureArray [1, 2] = 5;
			fieldStructureArray [1, 3] = 5;
			fieldStructureArray [2, 1] = 5;
			fieldStructureArray [2, 2] = 5;
			fieldStructureArray [2, 3] = 5;
			fieldStructureArray [3, 1] = 5;
			fieldStructureArray [3, 2] = 5;
			fieldStructureArray [3, 3] = 5;
		}

		if (level == 205) {
			InitializeArraySize (5, 5);
			fieldStructureArray [1, 1] = 5;
			fieldStructureArray [1, 2] = 5;
			fieldStructureArray [1, 3] = 5;
			fieldStructureArray [2, 1] = 5;
			fieldStructureArray [2, 3] = 5;
			fieldStructureArray [3, 1] = 5;
			fieldStructureArray [3, 2] = 5;
			fieldStructureArray [3, 3] = 5;
		}

		if (level == 206) {
			InitializeArraySize (5, 5);
			fieldStructureArray [2, 2] = 5;
		}

		if (level == 207) {
			InitializeArraySize (3, 3);
			fieldStructureArray [0, 0] = 5;
			fieldStructureArray [1, 1] = 5;
			fieldStructureArray [2, 2] = 5;
		}

		if (level == 208) {
			InitializeArraySize (3, 3);
			fieldStructureArray [1, 0] = 5;
		}

		if (level == 209) {
			InitializeArraySize (3, 3);
			fieldStructureArray [0, 0] = 5;
			fieldStructureArray [1, 1] = 5;
		}

		if (level == 210) {
			InitializeArraySize (4, 4);
			fieldStructureArray [0, 0] = 2;
			fieldStructureArray [0, 1] = 5;
			fieldStructureArray [1, 0] = 5;
			fieldStructureArray [1, 1] = 5;
			fieldStructureArray [2, 2] = 5;
			fieldStructureArray [2, 3] = 5;
			fieldStructureArray [3, 2] = 5;
			fieldStructureArray [3, 3] = 2;
		}

		if (level == 211) {
			InitializeArraySize (4, 4);
			fieldStructureArray [0, 0] = 5;
		}

		if (level == 212) {
			InitializeArraySize (4, 4);
			fieldStructureArray [0, 0] = 2;
			fieldStructureArray [3, 0] = 5;
			fieldStructureArray [3, 1] = 5;
			fieldStructureArray [3, 2] = 5;
			fieldStructureArray [3, 3] = 5;
		}

		if (level == 213) {
			InitializeArraySize (4, 4);
			fieldStructureArray [0, 0] = 2;
			fieldStructureArray [1, 1] = 5;
			fieldStructureArray [2, 2] = 5;
			fieldStructureArray [3, 3] = 2;
		}

		if (level == 214) {
			InitializeArraySize (4, 4);
			fieldStructureArray [0, 0] = 5;
			fieldStructureArray [0, 3] = 5;
			fieldStructureArray [3, 0] = 5;
			fieldStructureArray [3, 3] = 5;
		}

		if (level == 215) {
			InitializeArraySize (5, 5);
			fieldStructureArray [1, 1] = 5;
			fieldStructureArray [1, 2] = 5;
			fieldStructureArray [1, 3] = 5;
			fieldStructureArray [3, 1] = 5;
			fieldStructureArray [3, 2] = 5;
			fieldStructureArray [3, 3] = 5;
		}

		if (level == 216) {
			InitializeArraySize (6, 6);
			fieldStructureArray [0, 0] = 2;
			fieldStructureArray [0, 1] = 2;
			fieldStructureArray [0, 4] = 2;
			fieldStructureArray [0, 5] = 2;

			fieldStructureArray [1, 0] = 2;
			fieldStructureArray [1, 1] = 2;
			fieldStructureArray [1, 2] = 5;
			fieldStructureArray [1, 3] = 5;
			fieldStructureArray [1, 4] = 2;
			fieldStructureArray [1, 5] = 2;

			fieldStructureArray [2, 1] = 5;
			fieldStructureArray [2, 2] = 5;
			fieldStructureArray [2, 3] = 5;
			fieldStructureArray [2, 4] = 5;

			fieldStructureArray [3, 1] = 5;
			fieldStructureArray [3, 2] = 5;
			fieldStructureArray [3, 3] = 5;
			fieldStructureArray [3, 4] = 5;

			fieldStructureArray [4, 0] = 2;
			fieldStructureArray [4, 1] = 2;
			fieldStructureArray [4, 2] = 5;
			fieldStructureArray [4, 3] = 5;
			fieldStructureArray [4, 4] = 2;
			fieldStructureArray [4, 5] = 2;

			fieldStructureArray [5, 0] = 2;
			fieldStructureArray [5, 1] = 2;
			fieldStructureArray [5, 4] = 2;
			fieldStructureArray [5, 5] = 2;
		}

		if (level == 217) {
			InitializeArraySize (5, 5);
			fieldStructureArray [0, 0] = 2;
			fieldStructureArray [1, 2] = 5;
			fieldStructureArray [2, 1] = 5;
			fieldStructureArray [2, 2] = 5;
			fieldStructureArray [2, 3] = 5;
			fieldStructureArray [3, 2] = 5;
		}

		if (level == 218) {
			InitializeArraySize (3, 3);
			fieldStructureArray [1, 1] = 5;
		}

		if (level == 219) {
			InitializeArraySize (3, 3);
			fieldStructureArray [0, 0] = 5;
			fieldStructureArray [1, 0] = 5;
			fieldStructureArray [1, 1] = 5;
			fieldStructureArray [2, 0] = 5;
		}

		if (level == 220) {
			InitializeArraySize (5, 5);
			fieldStructureArray [0, 0] = 2;
			fieldStructureArray [0, 2] = 5;
			fieldStructureArray [0, 4] = 2;
			fieldStructureArray [2, 0] = 5;
			fieldStructureArray [2, 2] = 5;
			fieldStructureArray [2, 4] = 5;
			fieldStructureArray [4, 0] = 2;
			fieldStructureArray [4, 2] = 5;
			fieldStructureArray [4, 4] = 2;
		}

		if (level == 221) {
			InitializeArraySize (4, 4);
			fieldStructureArray [0, 0] = 5;
			fieldStructureArray [1, 1] = 5;
			fieldStructureArray [2, 2] = 5;
			fieldStructureArray [3, 3] = 5;
		}

		if (level == 222) {
			InitializeArraySize (4, 4);
			fieldStructureArray [0, 0] = 5;
			fieldStructureArray [3, 3] = 5;
		}

		if (level == 223) {
			InitializeArraySize (5, 5);
			fieldStructureArray [0, 0] = 5;
			fieldStructureArray [0, 4] = 5;
			fieldStructureArray [4, 0] = 5;
			fieldStructureArray [4, 4] = 5;
		}


		//////LEVEL 300 - 399/----------------------------------------------------
		if (level == 300) {
			InitializeArraySize (6, 6);
			fieldStructureArray [0, 0] = 2;
			fieldStructureArray [0, 1] = 2;
			fieldStructureArray [0, 4] = 2;
			fieldStructureArray [0, 5] = 2;
			fieldStructureArray [1, 0] = 2;
			fieldStructureArray [1, 1] = 2;
			fieldStructureArray [1, 4] = 2;
			fieldStructureArray [1, 5] = 2;
			fieldStructureArray [2, 0] = 2;
			fieldStructureArray [2, 1] = 2;
			fieldStructureArray [2, 4] = 2;
			fieldStructureArray [2, 5] = 2;
			fieldStructureArray [3, 0] = 2;
			fieldStructureArray [3, 1] = 2;
			fieldStructureArray [3, 4] = 2;
			fieldStructureArray [3, 5] = 2;
			fieldStructureArray [5, 2] = 2;
			fieldStructureArray [5, 3] = 2;
		}

		if (level == 301) {
			InitializeArraySize (6, 4);
			fieldStructureArray [1, 1] = 2;
			fieldStructureArray [1, 2] = 2;
			fieldStructureArray [2, 1] = 2;
			fieldStructureArray [2, 2] = 2;
			fieldStructureArray [4, 1] = 2;
			fieldStructureArray [4, 2] = 2;
			fieldStructureArray [4, 3] = 2;
			fieldStructureArray [5, 1] = 2;
			fieldStructureArray [5, 2] = 2;
			fieldStructureArray [5, 3] = 2;
		}

		if (level == 302) {
			InitializeArraySize (4, 4);
			fieldStructureArray [0, 1] = 2;
			fieldStructureArray [0, 2] = 2;
			fieldStructureArray [1, 1] = 2;
			fieldStructureArray [2, 2] = 2;
			fieldStructureArray [3, 1] = 2;
			fieldStructureArray [3, 2] = 2;
		}

		if (level == 303) {
			InitializeArraySize (5, 5);
			fieldStructureArray [0, 0] = 2;
			fieldStructureArray [0, 2] = 2;
			fieldStructureArray [0, 3] = 2;
			fieldStructureArray [1, 0] = 2;
			fieldStructureArray [3, 2] = 2;
			fieldStructureArray [3, 3] = 2;
			fieldStructureArray [4, 0] = 2;
			fieldStructureArray [4, 1] = 2;
			fieldStructureArray [4, 2] = 2;
			fieldStructureArray [4, 3] = 2;
		}

		if (level == 304) {
			InitializeArraySize (5, 5);
			fieldStructureArray [0, 0] = 2;
			fieldStructureArray [0, 4] = 2;
			fieldStructureArray [1, 2] = 2;
			fieldStructureArray [2, 1] = 2;
			fieldStructureArray [2, 2] = 2;
			fieldStructureArray [2, 3] = 2;
			fieldStructureArray [3, 2] = 2;
			fieldStructureArray [4, 0] = 2;
			fieldStructureArray [4, 4] = 2;
		}

		if (level == 305) {
			InitializeArraySize (5, 4);
			fieldStructureArray [1, 1] = 2;
			fieldStructureArray [1, 2] = 2;
			fieldStructureArray [3, 1] = 2;
			fieldStructureArray [3, 2] = 2;
		}

		if (level == 306) {
			InitializeArraySize (4, 4);
			fieldStructureArray [0, 0] = 2;
			fieldStructureArray [0, 1] = 5;
			fieldStructureArray [0, 2] = 5;
			fieldStructureArray [0, 3] = 2;
			fieldStructureArray [1, 0] = 5;
			fieldStructureArray [1, 3] = 5;
			fieldStructureArray [2, 0] = 5;
			fieldStructureArray [2, 3] = 5;
			fieldStructureArray [3, 0] = 2;
			fieldStructureArray [3, 1] = 5;
			fieldStructureArray [3, 2] = 5;
			fieldStructureArray [3, 3] = 2;
		}

		if (level == 307) {
			InitializeArraySize (6, 6);
			fieldStructureArray [0, 1] = 2;
			fieldStructureArray [0, 2] = 2;
			fieldStructureArray [0, 3] = 2;
			fieldStructureArray [0, 4] = 2;
			fieldStructureArray [0, 5] = 2;
			fieldStructureArray [1, 2] = 2;
			fieldStructureArray [1, 3] = 2;
			fieldStructureArray [1, 4] = 2;
			fieldStructureArray [1, 5] = 2;
			fieldStructureArray [2, 0] = 2;
			fieldStructureArray [2, 3] = 2;
			fieldStructureArray [2, 4] = 2;
			fieldStructureArray [2, 5] = 2;
			fieldStructureArray [3, 0] = 2;
			fieldStructureArray [3, 1] = 2;
			fieldStructureArray [3, 4] = 2;
			fieldStructureArray [3, 5] = 2;
			fieldStructureArray [4, 0] = 2;
			fieldStructureArray [4, 1] = 2;
			fieldStructureArray [4, 2] = 2;
			fieldStructureArray [4, 5] = 2;
			fieldStructureArray [5, 0] = 2;
			fieldStructureArray [5, 1] = 2;
			fieldStructureArray [5, 2] = 2;
			fieldStructureArray [5, 3] = 2;
		}

		if (level == 308) {
			InitializeArraySize (5, 5);
			fieldStructureArray [1, 1] = 2;
			fieldStructureArray [1, 2] = 2;
			fieldStructureArray [1, 3] = 2;
			fieldStructureArray [1, 4] = 2;
			fieldStructureArray [3, 1] = 2;
			fieldStructureArray [3, 2] = 2;
			fieldStructureArray [3, 3] = 2;
			fieldStructureArray [3, 4] = 2;
		}

		if (level == 309) {
			InitializeArraySize (5, 4);
			fieldStructureArray [0, 3] = 2;
			fieldStructureArray [1, 1] = 2;
			fieldStructureArray [1, 2] = 2;
			fieldStructureArray [3, 1] = 2;
			fieldStructureArray [3, 2] = 2;
			fieldStructureArray [4, 3] = 2;
		}

		if (level == 310) {
			InitializeArraySize (5, 5);
			fieldStructureArray [0, 1] = 2;
			fieldStructureArray [0, 3] = 2;
			fieldStructureArray [1, 1] = 2;
			fieldStructureArray [1, 3] = 2;
			fieldStructureArray [3, 0] = 2;
			fieldStructureArray [3, 1] = 2;
			fieldStructureArray [3, 3] = 2;
			fieldStructureArray [3, 4] = 2;
			fieldStructureArray [4, 0] = 2;
			fieldStructureArray [4, 1] = 2;
			fieldStructureArray [4, 3] = 2;
			fieldStructureArray [4, 4] = 2;
		}

		if (level == 311) {
			InitializeArraySize (3, 3);
			fieldStructureArray [0, 0] = 5;
			fieldStructureArray [0, 1] = 5;
			fieldStructureArray [0, 2] = 5;
			fieldStructureArray [1, 0] = 5;
			fieldStructureArray [1, 2] = 5;
			fieldStructureArray [2, 0] = 5;
			fieldStructureArray [2, 1] = 5;
			fieldStructureArray [2, 2] = 5;
		}

		if (level == 312) {
			InitializeArraySize (6, 6);
			fieldStructureArray [0, 5] = 2;
			fieldStructureArray [1, 0] = 2;
			fieldStructureArray [2, 5] = 2;
			fieldStructureArray [3, 0] = 2;
			fieldStructureArray [4, 5] = 2;
			fieldStructureArray [5, 0] = 2;
		}

		if (level == 313) {
			InitializeArraySize (6, 6);
			fieldStructureArray [0, 2] = 2;
			fieldStructureArray [0, 3] = 2;
			fieldStructureArray [1, 2] = 2;
			fieldStructureArray [1, 3] = 2;
			fieldStructureArray [4, 2] = 2;
			fieldStructureArray [4, 3] = 2;
			fieldStructureArray [5, 2] = 2;
			fieldStructureArray [5, 3] = 2;
		}

		if (level == 314) {
			InitializeArraySize (6, 6);
			fieldStructureArray [0, 5] = 2;
			fieldStructureArray [1, 0] = 2;
			fieldStructureArray [2, 4] = 2;
			fieldStructureArray [2, 5] = 2;
			fieldStructureArray [3, 0] = 2;
			fieldStructureArray [3, 1] = 2;
			fieldStructureArray [4, 3] = 2;
			fieldStructureArray [4, 4] = 2;
			fieldStructureArray [4, 5] = 2;
			fieldStructureArray [5, 0] = 2;
			fieldStructureArray [5, 1] = 2;
			fieldStructureArray [5, 2] = 2;
		}

		if (level == 315) {
			InitializeArraySize (6, 6);
			fieldStructureArray [0, 0] = 5;
			fieldStructureArray [0, 1] = 5;
			fieldStructureArray [0, 2] = 2;
			fieldStructureArray [0, 3] = 2;
			fieldStructureArray [0, 4] = 5;
			fieldStructureArray [0, 5] = 5;
			fieldStructureArray [3, 0] = 2;
			fieldStructureArray [3, 5] = 2;
			fieldStructureArray [4, 0] = 2;
			fieldStructureArray [4, 1] = 2;
			fieldStructureArray [4, 4] = 2;
			fieldStructureArray [4, 5] = 2;
			fieldStructureArray [5, 0] = 2;
			fieldStructureArray [5, 1] = 2;
			fieldStructureArray [5, 4] = 2;
			fieldStructureArray [5, 5] = 2;
		}

		if (level == 316) {
			InitializeArraySize (5, 3);
			fieldStructureArray [1, 1] = 2;
			fieldStructureArray [3, 1] = 2;
			fieldStructureArray [3, 2] = 2;
			fieldStructureArray [4, 1] = 2;
			fieldStructureArray [4, 2] = 2;
		}

		if (level == 317) {
			InitializeArraySize (6, 5);
			fieldStructureArray [0, 1] = 2;
			fieldStructureArray [0, 3] = 2;
			fieldStructureArray [1, 1] = 2;
			fieldStructureArray [1, 3] = 2;
			fieldStructureArray [2, 1] = 2;
			fieldStructureArray [2, 3] = 2;
			fieldStructureArray [4, 0] = 2;
			fieldStructureArray [4, 1] = 2;
			fieldStructureArray [4, 3] = 2;
			fieldStructureArray [4, 4] = 2;
			fieldStructureArray [5, 0] = 2;
			fieldStructureArray [5, 1] = 2;
			fieldStructureArray [5, 3] = 2;
			fieldStructureArray [5, 4] = 2;
		}

		if (level == 318) {
			InitializeArraySize (5, 5);
			fieldStructureArray [0, 0] = 2;
			fieldStructureArray [0, 1] = 2;
			fieldStructureArray [1, 1] = 2;
			fieldStructureArray [1, 3] = 2;
			fieldStructureArray [2, 1] = 2;
			fieldStructureArray [2, 3] = 2;
			fieldStructureArray [3, 1] = 2;
			fieldStructureArray [3, 3] = 2;
			fieldStructureArray [4, 3] = 2;
			fieldStructureArray [4, 4] = 2;
		}

		if (level == 319) {
			InitializeArraySize (4, 4);
			fieldStructureArray [0, 0] = 5;
			fieldStructureArray [0, 1] = 5;
			fieldStructureArray [0, 2] = 5;
			fieldStructureArray [0, 3] = 5;
			fieldStructureArray [1, 0] = 5;
			fieldStructureArray [1, 3] = 5;
			fieldStructureArray [2, 0] = 5;
			fieldStructureArray [2, 3] = 5;
			fieldStructureArray [3, 0] = 5;
			fieldStructureArray [3, 1] = 5;
			fieldStructureArray [3, 2] = 5;
			fieldStructureArray [3, 3] = 5;
		}

		if (level == 320) {
			InitializeArraySize (6, 5);
			fieldStructureArray [0, 1] = 2;
			fieldStructureArray [0, 3] = 2;
			fieldStructureArray [1, 1] = 2;
			fieldStructureArray [1, 3] = 2;
			fieldStructureArray [3, 0] = 2;
			fieldStructureArray [3, 4] = 2;
			fieldStructureArray [4, 0] = 2;
			fieldStructureArray [4, 1] = 2;
			fieldStructureArray [4, 3] = 2;
			fieldStructureArray [4, 4] = 2;
			fieldStructureArray [5, 0] = 2;
			fieldStructureArray [5, 1] = 2;
			fieldStructureArray [5, 3] = 2;
			fieldStructureArray [5, 4] = 2;
		}

		if (level == 321) {
			InitializeArraySize (6, 5);
			fieldStructureArray [0, 0] = 5;
			fieldStructureArray [0, 1] = 2;
			fieldStructureArray [0, 2] = 5;
			fieldStructureArray [0, 3] = 2;
			fieldStructureArray [0, 4] = 5;
			fieldStructureArray [1, 0] = 5;
			fieldStructureArray [1, 1] = 2;
			fieldStructureArray [1, 2] = 5;
			fieldStructureArray [1, 3] = 2;
			fieldStructureArray [1, 4] = 5;
			fieldStructureArray [2, 0] = 5;
			fieldStructureArray [2, 1] = 2;
			fieldStructureArray [2, 2] = 5;
			fieldStructureArray [2, 3] = 2;
			fieldStructureArray [2, 4] = 5;
			fieldStructureArray [3, 0] = 5;
			fieldStructureArray [3, 1] = 5;
			fieldStructureArray [3, 2] = 5;
			fieldStructureArray [3, 3] = 5;
			fieldStructureArray [3, 4] = 5;
			fieldStructureArray [4, 0] = 2;
			fieldStructureArray [4, 1] = 2;
			fieldStructureArray [4, 3] = 2;
			fieldStructureArray [4, 4] = 2;
			fieldStructureArray [5, 0] = 2;
			fieldStructureArray [5, 1] = 2;
			fieldStructureArray [5, 3] = 2;
			fieldStructureArray [5, 4] = 2;
		}

		if (level == 322) {
			InitializeArraySize (6, 5);
			fieldStructureArray [0, 0] = 5;
			fieldStructureArray [0, 1] = 2;
			fieldStructureArray [0, 2] = 5;
			fieldStructureArray [0, 3] = 2;
			fieldStructureArray [0, 4] = 5;
			fieldStructureArray [1, 1] = 2;
			fieldStructureArray [1, 3] = 2;
			fieldStructureArray [4, 1] = 2;
			fieldStructureArray [4, 3] = 2;
			fieldStructureArray [5, 0] = 5;
			fieldStructureArray [5, 1] = 2;
			fieldStructureArray [5, 2] = 5;
			fieldStructureArray [5, 3] = 2;
			fieldStructureArray [5, 4] = 5;
		}

		if (level == 323) {
			InitializeArraySize (6, 6);
			fieldStructureArray [1, 1] = 2;
			fieldStructureArray [1, 4] = 2;
			fieldStructureArray [2, 1] = 2;
			fieldStructureArray [2, 4] = 2;
			fieldStructureArray [4, 1] = 2;
			fieldStructureArray [4, 2] = 2;
			fieldStructureArray [4, 3] = 2;
			fieldStructureArray [4, 4] = 2;
		}
		//////////////////////////////////////////////////

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
