using UnityEngine;
using System.Collections;

public class GameResetOnClick : MonoBehaviour {

	//Reset Function
    public void ResetGame()
    {
        // Reset Game Stats
        PlayerPrefs.DeleteAll();
        PlayerPrefs.SetInt("NumberOfAppStarts", 0);
        //PlayerPrefs.SetInt("TotalNumberOfMoves", 0);
        //PlayerPrefs.SetInt("TotalNumberOfTurn", 0);
        //PlayerPrefs.SetInt("TotalNumberOfResets", 0);
        // Es fehlt ein Reset für alle Sterne (klappt mit Delete All)

    } 
}
