using UnityEngine;
using System.Collections;

public class TreeTable : MonoBehaviour {
	//This script contains the values which decide how many trees (stars) you get, depending on the number of turns
	public int twoTrees; //Max number of turns to get two trees
	public int threeTrees; //Max number of turns to get three trees

	public int GetNumberOfTrees(int levelNumber, int numberOfTurns)
	{

		GetValues (levelNumber);
		int achievedTrees;

		//Set the definitive number of achieved Trees
		if(numberOfTurns <= threeTrees)
		{
			achievedTrees = 3;
		}
		else if(numberOfTurns <= twoTrees)
		{
			achievedTrees = 2;
		}
		else
		{
			achievedTrees = 1;
		}

		return achievedTrees; //return the number of achieved trees

	}

	//Get the maximum number of turns to display it in the game scene (Pro Only)
	public void GetValuesPro()
	{
		GetValues (PlayerPrefs.GetInt ("ChosenLevel"));
	}

	//THe value to all levels are stored here
	void GetValues(int levelNumber)
	{
		switch(levelNumber)
		{
			case 100: twoTrees = 3; threeTrees = 1; break;
			case 101: twoTrees = 4; threeTrees = 2; break;
			case 102: twoTrees = 4; threeTrees = 2; break;
			case 103: twoTrees = 6; threeTrees = 4; break;
			case 104: twoTrees = 7; threeTrees = 4; break;
			case 105: twoTrees = 6; threeTrees = 3; break;
			case 106: twoTrees = 6; threeTrees = 3; break;
			case 107: twoTrees = 4; threeTrees = 2; break;
			case 108: twoTrees = 6; threeTrees = 4; break;
			case 109: twoTrees = 6; threeTrees = 4; break;
			case 110: twoTrees = 5; threeTrees = 2; break;
			case 111: twoTrees = 8; threeTrees = 4; break;
			case 112: twoTrees = 8; threeTrees = 4; break;
			case 113: twoTrees = 6; threeTrees = 3; break;
			case 114: twoTrees = 5; threeTrees = 3; break;
			case 115: twoTrees = 8; threeTrees = 5; break;
			case 116: twoTrees = 8; threeTrees = 5; break;
			case 117: twoTrees = 8; threeTrees = 5; break;
			case 118: twoTrees = 12; threeTrees = 6; break;
			case 119: twoTrees = 8; threeTrees = 4; break;
			case 120: twoTrees = 7; threeTrees = 4; break;
			case 121: twoTrees = 12; threeTrees = 8; break;
			case 122: twoTrees = 14; threeTrees = 7; break;
			case 123: twoTrees = 16; threeTrees = 9; break;

			case 200: twoTrees = 4; threeTrees = 2; break;
			case 201: twoTrees = 6; threeTrees = 3; break;
			case 202: twoTrees = 6; threeTrees = 3; break;
			case 203: twoTrees = 4; threeTrees = 2; break;
			case 204: twoTrees = 8; threeTrees = 5; break;
			case 205: twoTrees = 9; threeTrees = 5; break;
			case 206: twoTrees = 6; threeTrees = 4; break;
			case 207: twoTrees = 8; threeTrees = 4; break;
			case 208: twoTrees = 8; threeTrees = 5; break;
			case 209: twoTrees = 10; threeTrees = 6; break;
			case 210: twoTrees = 11; threeTrees = 6; break;
			case 211: twoTrees = 12; threeTrees = 7; break;
			case 212: twoTrees = 9; threeTrees = 6; break;
			case 213: twoTrees = 10; threeTrees = 6; break;
			case 214: twoTrees = 14; threeTrees = 8; break;
			case 215: twoTrees = 12; threeTrees = 7; break;
			case 216: twoTrees = 12; threeTrees = 6; break;
			case 217: twoTrees = 14; threeTrees = 8; break;
			case 218: twoTrees = 12; threeTrees = 8; break;
			case 219: twoTrees = 12; threeTrees = 8; break;
			case 220: twoTrees = 14; threeTrees = 8; break;
			case 221: twoTrees = 18; threeTrees = 10; break;
			case 222: twoTrees = 22; threeTrees = 14; break;
			case 223: twoTrees = 22; threeTrees = 13; break;
		}
	}
}
