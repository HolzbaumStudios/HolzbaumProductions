using UnityEngine;
using System.Collections;

public class turnExitOnClick : MonoBehaviour {
	
	// Variablen
	public GameObject squareE;
	public GameObject squareX;
	public GameObject squareI;
	public GameObject squareT;
	
	// Funktionen
	public void TurnButton()
	{
		StartCoroutine (TurnExit ());
	}
	
	
	
	
	//Coroutine
	IEnumerator TurnExit() {
		squareE.GetComponent<Animation> ().Play();
		yield return new WaitForSeconds(0.25f);
		squareE.GetComponent<UnityEngine.UI.Image> ().color = new Color32(240, 120, 48, 255);
		squareE.transform.Find ("Letter").gameObject.SetActive (false);
		squareX.GetComponent<Animation> ().Play();
		yield return new WaitForSeconds(0.25f);
		squareX.GetComponent<UnityEngine.UI.Image> ().color = new Color32(240, 120, 48, 255);
		squareX.transform.Find ("Letter").gameObject.SetActive (false);
		squareI.GetComponent<Animation> ().Play();
		yield return new WaitForSeconds(0.25f);
		squareI.GetComponent<UnityEngine.UI.Image> ().color = new Color32(240, 120, 48, 255);
		squareI.transform.Find ("Letter").gameObject.SetActive (false);
		squareT.GetComponent<Animation> ().Play();
		yield return new WaitForSeconds(0.25f);
		squareT.GetComponent<UnityEngine.UI.Image> ().color = new Color32(240, 120, 48, 255);
		squareT.transform.Find ("Letter").gameObject.SetActive (false);
		yield return new WaitForSeconds(0.5f);
		Application.Quit();
	}
	
	
}