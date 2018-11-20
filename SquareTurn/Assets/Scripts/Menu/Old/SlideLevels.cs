using UnityEngine;
using System.Collections;

public class SlideLevels : MonoBehaviour {

	public void SlideMenu()
	{
		gameObject.GetComponent<Animator> ().SetTrigger ("slideLeft");
	}
}
