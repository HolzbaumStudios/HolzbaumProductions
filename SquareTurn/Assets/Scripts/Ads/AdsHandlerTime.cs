using UnityEngine;
using System.Collections;

public class AdsHandlerTime : MonoBehaviour {

	float timer = 510;
	
	// Update is called once per frame
	void Update () {
		timer += Time.deltaTime;
		Debug.Log ("Time: " + timer);

		if(timer > 600)
		{
			if(Application.loadedLevelName == "levelMenu")
			{
				timer = 0;
				GameObject.Find("AdsHandler").GetComponent<AdsHandler>().EnableAds();

			}
		}
	}
}
