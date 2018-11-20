using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class ArrowLevelchoice : MonoBehaviour {

	//This script is attached to the arrowsw in the levelChoice

	public GameObject scrollObject;


	public void ScrollLevelMenu(float scrollValue)
	{
		scrollObject.GetComponent<Scrollbar> ().value = scrollValue;
        PlayerPrefs.SetFloat("SliderPosition", scrollValue);
    }
}
