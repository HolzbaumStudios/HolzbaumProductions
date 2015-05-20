using UnityEngine;
using System.Collections;

public class TreeTable : MonoBehaviour {
	//This script contains the values which decide how many trees (stars) you get, depending on the number of turns
	private int twoTrees; //Max number of turns to get two trees
	private int threeTrees; //Max number of turns to get three trees

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

	//THe value to all levels are stored here
	void GetValues(int levelNumber)
	{
		switch(levelNumber)
		{
			case 100: twoTrees = 4; threeTrees = 1; break;
			case 101: twoTrees = 2; threeTrees = 3; break;
			case 102: twoTrees = 4; threeTrees = 3; break;
		}
	}
}
