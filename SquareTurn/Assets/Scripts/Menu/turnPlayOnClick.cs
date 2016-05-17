using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class turnPlayOnClick : MonoBehaviour {

	// Variablen
	public GameObject squareP;
	public GameObject squareL;
	public GameObject squareA;
	public GameObject squareY;

	// Funktionen
	public void TurnButton()
	{
		StartCoroutine(TurnPlay ());
	}




	//Coroutine
	IEnumerator TurnPlay() {
		squareP.GetComponent<Animation> ().Play();
		yield return new WaitForSeconds(0.25f);
		squareP.GetComponent<UnityEngine.UI.Image> ().color = new Color32(240, 120, 48, 255);
		squareP.transform.FindChild ("Letter").gameObject.SetActive (false);
		squareL.GetComponent<Animation> ().Play();
		yield return new WaitForSeconds(0.25f);
		squareL.GetComponent<UnityEngine.UI.Image> ().color = new Color32(240, 120, 48, 255);
		squareL.transform.FindChild ("Letter").gameObject.SetActive (false);
		squareA.GetComponent<Animation> ().Play();
		yield return new WaitForSeconds(0.25f);
		squareA.GetComponent<UnityEngine.UI.Image> ().color = new Color32(240, 120, 48, 255);
		squareA.transform.FindChild ("Letter").gameObject.SetActive (false);
		squareY.GetComponent<Animation> ().Play();
		yield return new WaitForSeconds(0.25f);
		squareY.GetComponent<UnityEngine.UI.Image> ().color = new Color32(240, 120, 48, 255);
		squareY.transform.FindChild ("Letter").gameObject.SetActive (false);
		yield return new WaitForSeconds(0.5f);

		PlayerPrefs.SetInt ("ActiveCategory", 0); //Set the the levelcategory to none (with this, the category selection is displayed)
        SceneManager.LoadScene("levelMenu");
	}


}
