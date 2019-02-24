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
			case 123: twoTrees = 8; threeTrees = 4; break;

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

			case 300: twoTrees = 7; threeTrees = 3; break;
			case 301: twoTrees = 8; threeTrees = 4; break;
			case 302: twoTrees = 8; threeTrees = 4; break;
			case 303: twoTrees = 9; threeTrees = 4; break;
			case 304: twoTrees = 8; threeTrees = 4; break;
			case 305: twoTrees = 8; threeTrees = 4; break;
			case 306: twoTrees = 10; threeTrees = 5; break;
			case 307: twoTrees = 7; threeTrees = 3; break;
			case 308: twoTrees = 10; threeTrees = 5; break;
			case 309: twoTrees = 9; threeTrees = 5; break;
			case 310: twoTrees = 12; threeTrees = 7; break;
			case 311: twoTrees = 15; threeTrees = 9; break;
			case 312: twoTrees = 8; threeTrees = 4; break;
			case 313: twoTrees = 8; threeTrees = 4; break;
			case 314: twoTrees = 10; threeTrees = 5; break;
			case 315: twoTrees = 12; threeTrees = 7; break;
			case 316: twoTrees = 12; threeTrees = 7; break;
			case 317: twoTrees = 14; threeTrees = 7; break;
			case 318: twoTrees = 12; threeTrees = 6; break;
			case 319: twoTrees = 25; threeTrees = 16; break;
			case 320: twoTrees = 16; threeTrees = 9; break;
			case 321: twoTrees = 20; threeTrees = 11; break;
			case 322: twoTrees = 28; threeTrees = 17; break;
			case 323: twoTrees = 32; threeTrees = 16; break;

            case 400: twoTrees = 6; threeTrees = 4; break;  //tree
            case 401: twoTrees = 6; threeTrees = 3; break;  //boat
            case 402: twoTrees = 5; threeTrees = 3; break;  //shoe
            case 403: twoTrees = 6; threeTrees = 4; break;  //heart
            case 404: twoTrees = 6; threeTrees = 3; break;  //lightbulb
            case 405: twoTrees = 10; threeTrees = 6; break;  //xmastree
            case 406: twoTrees = 18; threeTrees = 12; break;  //bottle
            case 407: twoTrees = 9; threeTrees = 6; break;  //mouse
            case 408: twoTrees = 12; threeTrees = 8; break;  //sun
            case 409: twoTrees = 17; threeTrees = 11; break;  //rocket1
            case 410: twoTrees = 14; threeTrees = 9; break;  //sword
            case 411: twoTrees = 14; threeTrees = 10; break;  //frog
            case 412: twoTrees = 18; threeTrees = 12; break;  //house
            case 413: twoTrees = 20; threeTrees = 13; break;  //roflcopter
            case 414: twoTrees = 10; threeTrees = 6; break;	//plane
            case 415: twoTrees = 6; threeTrees = 3; break; //desktop lamp
            case 416: twoTrees = 8; threeTrees = 5; break; //tie
            case 417: twoTrees = 11; threeTrees = 7; break; //rocket2
            case 418: twoTrees = 8; threeTrees = 5; break; //lamp upside down
            case 419: twoTrees = 9; threeTrees = 6; break; //art
            case 420: twoTrees = 15; threeTrees = 10; break; //candle holder
            case 421: twoTrees = 10; threeTrees = 6; break; //ankh
            case 422: twoTrees = 10; threeTrees = 7; break; //bomb
            case 423: twoTrees = 14; threeTrees = 9; break; //screwdriver

        }
	}
}
