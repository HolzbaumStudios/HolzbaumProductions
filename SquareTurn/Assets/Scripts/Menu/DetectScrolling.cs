using UnityEngine;
using System.Collections;

public class DetectScrolling : MonoBehaviour {

    //This script detects scrolling on the level menu

    GameObject scrollbar;

    void Start()
    {
        scrollbar = this.transform.Find("Scrollbar").gameObject;
    }

    public void DetectScrollChange()
    {
        float prefValue = PlayerPrefs.GetFloat("SliderPosition");
        float scrollRectValue = scrollbar.GetComponent<UnityEngine.UI.Scrollbar>().value;
        if (scrollRectValue != prefValue)
        {
            PlayerPrefs.SetFloat("SliderPosition", scrollRectValue);
        }
    }	

}
