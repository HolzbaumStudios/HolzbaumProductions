using UnityEngine;
using System.Collections;

public class CheckDeviceOrientation : MonoBehaviour {

	//Variables
	public GameObject LandscapeCanvas; //Placeholder for the landscape GUI
	public GameObject PortraitCanvas; //Placeholder for the portrait GUI

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.deviceOrientation == DeviceOrientation.Portrait){
			LandscapeCanvas.SetActive(false);
			PortraitCanvas.SetActive (true);
		}else if(Input.deviceOrientation == DeviceOrientation.LandscapeLeft || Input.deviceOrientation == DeviceOrientation.LandscapeRight){
			LandscapeCanvas.SetActive(true);
			PortraitCanvas.SetActive (false);
		}
	}
}
