using UnityEngine;
using System.Collections;

public class musicOnOff : MonoBehaviour {

	// Variablen
	private GameObject squareMusicButton;
	public bool status;
	public bool firststart;


	// Funktionen
	void Update(){
		if (Application.loadedLevelName == "startMenu" && firststart == true) {
			this.GetComponent<AudioSource>().Play();
			firststart = false;
		}
	}


	public void TurnButton(GameObject musicButton)
	{
		squareMusicButton = musicButton;

		if (status == true)
		{
			squareMusicButton.GetComponent<UnityEngine.UI.Image> ().color = new Color32(131, 139, 139, 255);
			squareMusicButton.transform.FindChild ("LetterRot1").gameObject.SetActive (true);
			squareMusicButton.transform.FindChild ("LetterRot2").gameObject.SetActive (true);
			this.GetComponent<AudioSource>().Pause();
			status = false;
		}
		else if (status == false)
		{
			squareMusicButton.GetComponent<UnityEngine.UI.Image> ().color = new Color32(72, 120, 168, 255);
			squareMusicButton.transform.FindChild ("LetterRot1").gameObject.SetActive (false);
			squareMusicButton.transform.FindChild ("LetterRot2").gameObject.SetActive (false);
			this.GetComponent<AudioSource>().Play();
			status = true;
		}
	}
}
