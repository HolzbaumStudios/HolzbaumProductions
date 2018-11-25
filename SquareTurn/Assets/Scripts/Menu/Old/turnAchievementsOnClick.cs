using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class turnAchievementsOnClick : MonoBehaviour {
	
	// Variablen
	public GameObject squareA;
	public GameObject squareC;
	public GameObject squareH;
	public GameObject squareI;
	public GameObject squareE;
	public GameObject squareV;
	public GameObject squareE2;
	public GameObject squareM;
	public GameObject squareE3;
	public GameObject squareN;
	public GameObject squareT;
	public GameObject squareS;
	
	// Funktionen
	public void TurnButton()
	{
		StartCoroutine(TurnPlay ());
	}
	
	//Coroutine
	IEnumerator TurnPlay() {
		squareA.GetComponent<Animation> ().Play();
		yield return new WaitForSeconds(0.0625f);
		squareA.GetComponent<UnityEngine.UI.Image> ().color = new Color32(240, 120, 48, 255);
		squareA.transform.Find ("Letter").gameObject.SetActive (false);
		squareC.GetComponent<Animation> ().Play();
		yield return new WaitForSeconds(0.0625f);
		squareC.GetComponent<UnityEngine.UI.Image> ().color = new Color32(240, 120, 48, 255);
		squareC.transform.Find ("Letter").gameObject.SetActive (false);
		squareH.GetComponent<Animation> ().Play();
		yield return new WaitForSeconds(0.0625f);
		squareH.GetComponent<UnityEngine.UI.Image> ().color = new Color32(240, 120, 48, 255);
		squareH.transform.Find ("Letter").gameObject.SetActive (false);
		squareI.GetComponent<Animation> ().Play();
		yield return new WaitForSeconds(0.0625f);
		squareI.GetComponent<UnityEngine.UI.Image> ().color = new Color32(240, 120, 48, 255);
		squareI.transform.Find ("Letter").gameObject.SetActive (false);
		squareE.GetComponent<Animation> ().Play();
		yield return new WaitForSeconds(0.0625f);
		squareE.GetComponent<UnityEngine.UI.Image> ().color = new Color32(240, 120, 48, 255);
		squareE.transform.Find ("Letter").gameObject.SetActive (false);
		squareV.GetComponent<Animation> ().Play();
		yield return new WaitForSeconds(0.0625f);
		squareV.GetComponent<UnityEngine.UI.Image> ().color = new Color32(240, 120, 48, 255);
		squareV.transform.Find ("Letter").gameObject.SetActive (false);
		squareE2.GetComponent<Animation> ().Play();
		yield return new WaitForSeconds(0.0625f);
		squareE2.GetComponent<UnityEngine.UI.Image> ().color = new Color32(240, 120, 48, 255);
		squareE2.transform.Find ("Letter").gameObject.SetActive (false);
		squareM.GetComponent<Animation> ().Play();
		yield return new WaitForSeconds(0.0625f);
		squareM.GetComponent<UnityEngine.UI.Image> ().color = new Color32(240, 120, 48, 255);
		squareM.transform.Find ("Letter").gameObject.SetActive (false);
		squareE3.GetComponent<Animation> ().Play();
		yield return new WaitForSeconds(0.0625f);
		squareE3.GetComponent<UnityEngine.UI.Image> ().color = new Color32(240, 120, 48, 255);
		squareE3.transform.Find ("Letter").gameObject.SetActive (false);
		squareN.GetComponent<Animation> ().Play();
		yield return new WaitForSeconds(0.0625f);
		squareN.GetComponent<UnityEngine.UI.Image> ().color = new Color32(240, 120, 48, 255);
		squareN.transform.Find ("Letter").gameObject.SetActive (false);
		squareT.GetComponent<Animation> ().Play();
		yield return new WaitForSeconds(0.0625f);
		squareT.GetComponent<UnityEngine.UI.Image> ().color = new Color32(240, 120, 48, 255);
		squareT.transform.Find ("Letter").gameObject.SetActive (false);
		squareS.GetComponent<Animation> ().Play();
		yield return new WaitForSeconds(0.0625f);
		squareS.GetComponent<UnityEngine.UI.Image> ().color = new Color32(240, 120, 48, 255);
		squareS.transform.Find ("Letter").gameObject.SetActive (false);

		yield return new WaitForSeconds(0.25f);
        SceneManager.LoadScene("achievements");
	}
}
