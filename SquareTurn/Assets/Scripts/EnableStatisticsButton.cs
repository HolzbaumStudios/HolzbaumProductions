using UnityEngine;
using System.Collections;

public class EnableStatisticsButton : MonoBehaviour {

	// Use this for initialization
	void Start () {
		GameObject userStatistics = GameObject.Find ("UserStatistics");

		// Check if Pro mode is enabled
		if(userStatistics.GetComponent<EnableProVersion>().proVersion == true)
		{
			gameObject.transform.FindChild("StatisticsButton").gameObject.SetActive(true);
		}
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
