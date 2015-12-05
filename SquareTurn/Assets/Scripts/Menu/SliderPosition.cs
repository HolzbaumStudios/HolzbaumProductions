using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class SliderPosition : MonoBehaviour {

	/// <summary>
	/// This script is attached to the category slider and detects any changes in slider Position 
	/// </summary>

	float sliderPosition;

	// Use this for initialization
	void OnEnable () {
		sliderPosition = PlayerPrefs.GetFloat ("SliderPosition");
	}
	
	// Update is called once per frame
	void Update () {
		float currentPosition = gameObject.GetComponent<Scrollbar> ().value;
		if(currentPosition != sliderPosition)
		{
			sliderPosition = currentPosition;
			PlayerPrefs.SetFloat ("SliderPosition", sliderPosition);
		}
	
	}
}
