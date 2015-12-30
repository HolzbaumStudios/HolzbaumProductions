using UnityEngine;
using System.Collections;

public class AdsHandler : MonoBehaviour {

	//This script is used to determine when an ad is shown
	//Every 8th time the ad is shown (on startup it is after the first level)


	public GameObject unityAdsObject; //Add the gameObject UnityAds to this reference

	/*// Use this for initialization
	void Awake() {
		int counter = PlayerPrefs.GetInt ("AdCounter");
		counter++;
		Debug.Log ("AdCounter: " + counter);
		if(counter >= 8)
		{

			unityAdsObject.SetActive(true);
			counter = 0;
		}
		PlayerPrefs.SetInt ("AdCounter", counter);

	}*/

	public void EnableAds()
	{
        #if UNITY_IOS || UNITY_ANDROID || UNITY_EDITOR
            unityAdsObject.SetActive(true);
        #endif
	}

}
