using UnityEngine;
using System.Collections;

public class musicOnOff : MonoBehaviour {

	// Variablen
	public GameObject squareMusic;
	public bool status;
	private GameObject musicBackground;


	// Funktionen
	void Start(){
		musicBackground = GameObject.Find ("Music_Background");
	}


	public void TurnButton()
	{
		if (status == true)
		{
			squareMusic.GetComponent<UnityEngine.UI.Image> ().color = new Color32(131, 139, 139, 255);
			squareMusic.transform.FindChild ("LetterRot1").gameObject.SetActive (true);
			squareMusic.transform.FindChild ("LetterRot2").gameObject.SetActive (true);
			musicBackground.GetComponent<AudioSource>().Pause();
			status = false;
		}
		else if (status == false)
		{
			squareMusic.GetComponent<UnityEngine.UI.Image> ().color = new Color32(72, 120, 168, 255);
			squareMusic.transform.FindChild ("LetterRot1").gameObject.SetActive (false);
			squareMusic.transform.FindChild ("LetterRot2").gameObject.SetActive (false);
			musicBackground.GetComponent<AudioSource>().Play();
			status = true;
		}
	}
}
