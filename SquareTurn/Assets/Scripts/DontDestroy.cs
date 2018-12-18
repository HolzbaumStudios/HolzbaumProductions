using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class DontDestroy : MonoBehaviour {

	//--------------SUMMARY----------
	///Game Objects stored in the public list, wills not be destroyed, when the scene is changed
	/////////////////////////////////

	//Variables
	public List<GameObject> objectList; //List is filled in the editor


	//------INITIALIZATION-------------
	void Start(){
		//Get the list length
		int listLength;
		listLength = objectList.Count;

		//Set all the objects in the list to not destroy
		for (int i = 0; i < listLength; i++) {
            GameObject gameObject = objectList[i];
            if (gameObject != null)
            {
                DontDestroyOnLoad(gameObject);
            }
		}

	}




}
