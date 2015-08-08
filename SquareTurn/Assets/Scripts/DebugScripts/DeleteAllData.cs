using UnityEngine;
using System.Collections;

public class DeleteAllData : MonoBehaviour {

	public void DeleteData()
	{
		PlayerPrefs.DeleteAll ();
		//Set Achievements back
		PlayerPrefs.SetInt ("Achievement0State", 0);
		PlayerPrefs.SetInt ("Achievement1State", 0);
		PlayerPrefs.SetInt ("Achievement2State", 0);
		PlayerPrefs.SetInt ("Achievement3State", 0);
		PlayerPrefs.SetInt ("Achievement4State", 0);
		PlayerPrefs.SetInt ("Achievement5State", 0);
		PlayerPrefs.SetInt ("Achievement6State", 0);
		PlayerPrefs.SetInt ("Achievement7State", 0);
		PlayerPrefs.SetInt ("Achievement8State", 0);
		PlayerPrefs.SetInt ("Achievement9State", 0);
		PlayerPrefs.SetInt ("Achievement10State", 0);
		PlayerPrefs.SetInt ("Achievement11State", 0);
		PlayerPrefs.SetInt ("Achievement12State", 0);
		PlayerPrefs.SetInt ("Achievement13State", 0);
		PlayerPrefs.SetInt ("Achievement14State", 0);
		PlayerPrefs.SetInt ("Achievement15State", 0);

		PlayerPrefs.SetInt ("TotalNumberOfTurns", 0);
		PlayerPrefs.SetInt ("TotalNumberOfMoves", 0);

		Debug.Log ("Data deleted!");
	}
}
