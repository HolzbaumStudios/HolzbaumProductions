using UnityEngine;
using System.Collections;

public class CountAppStarts : MonoBehaviour {
	
	// Use this for initialization
	void Start () {
		int numberOfAppStarts = PlayerPrefs.GetInt ("NumberOfAppStarts") + 1;
		PlayerPrefs.SetInt ("NumberOfAppStarts", numberOfAppStarts);
	}
}
