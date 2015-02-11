using UnityEngine;
using System.Collections;

public class MenuScript : MonoBehaviour {


	public IEnumerator StartLevel(){
		yield return new WaitForSeconds(0.1f);
		Application.LoadLevel ("gameScene");
	}

}
