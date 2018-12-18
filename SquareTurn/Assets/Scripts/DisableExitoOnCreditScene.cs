using UnityEngine;
using System.Collections;

public class DisableExitoOnCreditScene : MonoBehaviour {

    //This script is only used on the credit scene

    public GameObject exitButton;

	
	// Update is called once per frame
	void Update ()
    {
#if UNITY_IOS
        if(Screen.height > Screen.width && exitButton.activeSelf == false)
        {
            exitButton.SetActive(true);
        }
        else if(Screen.width > Screen.height && exitButton.activeSelf == true)
        {
            exitButton.SetActive(false);
        }
	
#endif
    }
}
