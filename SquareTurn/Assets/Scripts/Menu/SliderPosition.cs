using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class SliderPosition : MonoBehaviour {

	/// <summary>
	/// This script is attached to the category slider and detects any changes in slider Position 
	/// </summary>

	float sliderPosition;

    void Awake()
    {
        sliderPosition = PlayerPrefs.GetFloat("SliderPosition");
        gameObject.GetComponent<Scrollbar>().value = sliderPosition;

    }

	
	// Update is called once per frame
	void Update () {
        sliderPosition = PlayerPrefs.GetFloat("SliderPosition");
        gameObject.GetComponent<Scrollbar>().value = sliderPosition;
        /*float currentPosition = gameObject.GetComponent<Scrollbar> ().value;
		if(currentPosition != sliderPosition)
		{
            Debug.Log("Changed position! Category: " + currentPosition);
			sliderPosition = currentPosition;
			PlayerPrefs.SetFloat ("SliderPosition", sliderPosition);
		}*/

    }
}
