using UnityEngine;
using UnityEngine.SceneManagement;
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

		//Set all the objects in the list to not destroy
		for (int i = 0; i < objectList.Count; i++) {
			DontDestroyOnLoad(objectList[i]);
		}

		StartCoroutine (LoadLevel ());
	}


	IEnumerator LoadLevel(){
		yield return new WaitForSeconds (4);
        SceneManager.LoadScene(loadLevelName);
	}

}
