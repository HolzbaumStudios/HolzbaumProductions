using UnityEngine;
using System.Collections;

public class DisableByDevice : MonoBehaviour {

	// Use this for initialization
	void Start () {

        #if UNITY_IOS
            //Don't do anything on IOS
           
        #else
            //Disable on other 
            this.gameObject.SetActive(false);
        #endif
    }

}