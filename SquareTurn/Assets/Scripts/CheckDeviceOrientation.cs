﻿using UnityEngine;
using System.Collections;

public class CheckDeviceOrientation : MonoBehaviour {

	//Variables
	public GameObject LandscapeCanvas; //Placeholder for the landscape GUI
	public GameObject PortraitCanvas; //Placeholder for the portrait GUI

    // Update is called once per frame
    void Update()
    {
        if (true || Input.deviceOrientation == DeviceOrientation.Portrait)
        {
            PortraitCanvas.SetActive(true);
            //PortraitCanvas.GetComponent<UnityEngine.UI.Text>().text = LandscapeCanvas.GetComponent<UnityEngine.UI.Text>().text;
            LandscapeCanvas.SetActive(false);
        }
        else if (Input.deviceOrientation == DeviceOrientation.LandscapeLeft || Input.deviceOrientation == DeviceOrientation.LandscapeRight)
        {
            LandscapeCanvas.SetActive(true);
            //LandscapeCanvas.GetComponent<UnityEngine.UI.Text>().text = PortraitCanvas.GetComponent<UnityEngine.UI.Text>().text;
            PortraitCanvas.SetActive(false);
        }
    }
}
