using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class AdsHandlerTime : MonoBehaviour {

	float timer = 510;
	
	// Update is called once per frame
	void Update () {
		timer += Time.deltaTime;
        //Debug.Log("Timer: " + timer);
		if(timer > 600)
		{
            //Debug.Log(SceneManager.GetActiveScene().name);
			if(SceneManager.GetActiveScene().name == "levelMenu")
			{
				timer = 0;
				GameObject.Find("AdsHandler").GetComponent<AdsHandler>().EnableAds();

			}
		}
	}
}
