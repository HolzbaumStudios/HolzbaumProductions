using UnityEngine;
using UnityEngine.UI;
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

		GameObject userStatistics = GameObject.Find ("UserStatistics");
		int twoStarValue;
		int threeStarValue;

		//Check if Pro Mode is enabled
		if(userStatistics.GetComponent<EnableProVersion>().proVersion == true)
		{
			starInfoBoxLandscape.SetActive(true);
			starInfoBoxPortrait.SetActive(true);

			userStatistics.GetComponent<TreeTable>().GetValuesPro();

			twoStarValue = userStatistics.GetComponent<TreeTable>().twoTrees + 1;
			threeStarValue = userStatistics.GetComponent<TreeTable>().threeTrees + 1;

			string textValue = "<" + twoStarValue.ToString ();
			twoStarInfoLandscape.GetComponent<Text>().text = textValue;
			twoStarInfoPortrait.GetComponent<Text>().text = textValue;

			textValue = "<" + threeStarValue.ToString ();
			threeStarInfoLandscape.GetComponent<Text>().text = textValue;
			threeStarInfoPortrait.GetComponent<Text>().text = textValue;
		}
	
	}
	
}
