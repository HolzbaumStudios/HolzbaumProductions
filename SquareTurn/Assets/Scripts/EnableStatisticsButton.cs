using UnityEngine;
using System.Collections;

public class EnableStatisticsButton : MonoBehaviour {

	// Use this for initialization
	void Start () {
		GameObject userStatistics = GameObject.Find ("UserStatistics");
   
		gameObject.transform.Find("StatisticsButton").gameObject.SetActive(true);

	}
}
