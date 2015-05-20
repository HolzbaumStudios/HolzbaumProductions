using UnityEngine;
using System.Collections;

public class scrollCredits : MonoBehaviour {

	// Variables
	public int speed;
	Transform scrollText;

	void Start () {
		scrollText = gameObject.transform.Find ("TextScrolling");

	}

	// Update is called once per frame
	void Update () {
		scrollText.Translate (Vector3.up * Time.deltaTime * speed);
	}
}
