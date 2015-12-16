using UnityEngine;
using System.Collections;

public class scrollCredits : MonoBehaviour {

	// Variables
	public int speed;
	public Transform scrollText;
	public Transform scrollImage;
	

	// Update is called once per frame
	void Update () {
		scrollText.Translate (Vector3.up * Time.deltaTime * speed);
		if (scrollImage.localPosition.y < 0)
		{
			scrollImage.Translate (Vector3.up * Time.deltaTime * speed);
		}
	}
}
