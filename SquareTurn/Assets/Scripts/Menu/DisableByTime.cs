using UnityEngine;
using System.Collections;

public class DisableByTime : MonoBehaviour {

    public int seconds = 6;

	// Use this for initialization
	void Start () {
        StartCoroutine(DisableObject());
	}
	
	//Disable after some time
    IEnumerator DisableObject()
    {
        yield return new WaitForSeconds(seconds);
        this.gameObject.SetActive(false);
    }
}
