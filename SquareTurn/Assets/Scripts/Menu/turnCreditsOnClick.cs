using UnityEngine;
using System.Collections;

public class turnCreditsOnClick : MonoBehaviour {

	// Variablen
	public GameObject squareC;
	public GameObject squareR;
	public GameObject squareE;
	public GameObject squareD;
	public GameObject squareI;
	public GameObject squareT;
	public GameObject squareS;

	// Funktionen
	public void TurnButton()
	{
		StartCoroutine(TurnPlay ());
	}

	//Coroutine
	IEnumerator TurnPlay() {
		squareC.GetComponent<Animation> ().Play();
		yield return new WaitForSeconds(0.125f);
		squareC.GetComponent<UnityEngine.UI.Image> ().color = new Color32(240, 120, 48, 255);
		squareC.transform.FindChild ("Letter").gameObject.SetActive (false);
		squareR.GetComponent<Animation> ().Play();
		yield return new WaitForSeconds(0.125f);
		squareR.GetComponent<UnityEngine.UI.Image> ().color = new Color32(240, 120, 48, 255);
		squareR.transform.FindChild ("Letter").gameObject.SetActive (false);
		squareE.GetComponent<Animation> ().Play();
		yield return new WaitForSeconds(0.125f);
		squareE.GetComponent<UnityEngine.UI.Image> ().color = new Color32(240, 120, 48, 255);
		squareE.transform.FindChild ("Letter").gameObject.SetActive (false);
		squareD.GetComponent<Animation> ().Play();
		yield return new WaitForSeconds(0.125f);
		squareD.GetComponent<UnityEngine.UI.Image> ().color = new Color32(240, 120, 48, 255);
		squareD.transform.FindChild ("Letter").gameObject.SetActive (false);
		squareI.GetComponent<Animation> ().Play();
		yield return new WaitForSeconds(0.125f);
		squareI.GetComponent<UnityEngine.UI.Image> ().color = new Color32(240, 120, 48, 255);
		squareI.transform.FindChild ("Letter").gameObject.SetActive (false);
		squareT.GetComponent<Animation> ().Play();
		yield return new WaitForSeconds(0.125f);
		squareT.GetComponent<UnityEngine.UI.Image> ().color = new Color32(240, 120, 48, 255);
		squareT.transform.FindChild ("Letter").gameObject.SetActive (false);
		squareS.GetComponent<Animation> ().Play();
		yield return new WaitForSeconds(0.125f);
		squareS.GetComponent<UnityEngine.UI.Image> ().color = new Color32(240, 120, 48, 255);
		squareS.transform.FindChild ("Letter").gameObject.SetActive (false);
		yield return new WaitForSeconds(0.25f);
		Application.LoadLevel ("creditsScene");
	}
}
