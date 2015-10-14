using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class ArrowLevelchoice : MonoBehaviour {

	//This script is attached to the arrowsw in the levelChoice

	public GameObject scrollObject;


	public void ScrollLevelMenu(float scrollValue)
	{
		Debug.Log ("Executed Function. Value : " + scrollValue);
		scrollObject.GetComponent<Scrollbar> ().value = scrollValue;
	}
}
