using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class LevelNumberText : MonoBehaviour {

    int levelNumber;

	// Use this for initialization
	void Start () {
        levelNumber = PlayerPrefs.GetInt("ChosenLevel");
        levelNumber++;

        string levelText = levelNumber.ToString();
        char[] levelTextArray = new char[3];
        levelTextArray = levelText.ToCharArray();
        string finishedText;
        string firstCharacter = levelTextArray[0].ToString();
        string secondCharacter = levelTextArray[1].ToString();
        string thirdCharacter = levelTextArray[2].ToString();


        if (secondCharacter == "0")
        {
            finishedText = firstCharacter + "-" + thirdCharacter;
        }
        else
        {
            finishedText = finishedText = firstCharacter + "-" + secondCharacter + thirdCharacter;
        }

        this.gameObject.GetComponent<Text>().text = finishedText;

    }
}
