using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class SetStarsInPossesion : MonoBehaviour {

    [SerializeField]
    TextMeshProUGUI textComponent;

	// Use this for initialization
	void Start () {
        int countTotalStars = PlayerPrefs.GetInt("Category1Stars") + PlayerPrefs.GetInt("Category2Stars") + PlayerPrefs.GetInt("Category3Stars") + PlayerPrefs.GetInt("Category4Stars");
        textComponent.text = countTotalStars.ToString();
    }
}
