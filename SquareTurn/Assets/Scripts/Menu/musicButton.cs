using UnityEngine;
using System.Collections;

public class musicButton : MonoBehaviour {

	// Variablen
	GameObject musicOnOff;

	// Find musicOnOff Script
	public void FindScript() {
		musicOnOff = GameObject.Find ("Music_Background");
		musicOnOff.GetComponent<musicOnOff> ().TurnButton (this.gameObject);
	}
}
