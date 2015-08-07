using UnityEngine;
using System.Collections;

public class DeleteAllData : MonoBehaviour {

	public void DeleteData()
	{
		PlayerPrefs.DeleteAll ();
		Debug.Log ("Data deleted!");
	}
}
