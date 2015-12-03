using UnityEngine;
using System.Collections;

public class SetAdCounter : MonoBehaviour {
	//Set adCounter so that the ad is shown after the first level

	// Use this for initialization
	void Start () {
		PlayerPrefs.SetInt ("AdCounter", 6);
	}
}
