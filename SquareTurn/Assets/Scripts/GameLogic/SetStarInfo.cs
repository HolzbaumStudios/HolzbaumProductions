using UnityEngine;
using System.Collections;

public class SetStarInfo : MonoBehaviour {

	public GameObject starInfoBoxLandscape;
	public GameObject starInfoBoxPortrait;

	public GameObject threeStarInfoLandscape;
	public GameObject twoStarInfoLandscape;

	public GameObject threeStarInfoPortrait;
	public GameObject twoStarInfoPortrait;

	// Use this for initialization
	void Start () {

		//Check if Pro Mode is enabled
		if(GameObject.Find ("UserStatistics").GetComponent<EnableProVersion>().proVersion == true)
		{
			starInfoBoxLandscape.SetActive(true);
			starInfoBoxPortrait.SetActive(true);
		}
	
	}
	
}
