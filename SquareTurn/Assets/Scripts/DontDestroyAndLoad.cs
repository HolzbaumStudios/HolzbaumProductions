using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class DontDestroyAndLoad : MonoBehaviour {

	//--------------SUMMARY----------
	///Game Objects stored in the public list, wills not be destroyed, when the scene is changed
	/////////////////////////////////

	//Variables
	public List<GameObject> objectList; //List is filled in the editor
	public bool loadLevel = false;
	public string loadLevelName;

	//------INITIALIZATION-------------
	void Start(){
		//Get the list length
		int listLength;
		listLength = objectList.Count;

		//Set all the objects in the list to not destroy
		for (int i = 0; i < listLength; i++) {
			DontDestroyOnLoad(objectList[i]);
		}

		StartCoroutine (LoadLevel ());
	}


	IEnumerator LoadLevel(){
		yield return new WaitForSeconds (2);
		Application.LoadLevel (loadLevelName);
	}

}
