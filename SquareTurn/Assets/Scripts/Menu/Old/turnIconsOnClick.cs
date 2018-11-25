using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class turnIconsOnClick : MonoBehaviour {

	// Variablen
	public GameObject squareIcon;
	public GameObject squareButton;
	private string levelName;


	// Funktionen
	public void TurnIcon(string level)
	{
		levelName = level;
		StartCoroutine(TurnPlay ());
	}

	//Coroutine
	IEnumerator TurnPlay() {
		squareIcon.GetComponent<Animation> ().Play();
		yield return new WaitForSeconds(0.5f);
		squareIcon.GetComponent<UnityEngine.UI.Image> ().color = new Color32(240, 120, 48, 255);
		squareButton.GetComponent<UnityEngine.UI.Image>().enabled = false;
		yield return new WaitForSeconds(0.7f);
		Debug.Log (levelName);
        SceneManager.LoadScene(levelName);
	}
}
