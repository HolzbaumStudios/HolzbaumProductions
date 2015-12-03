using UnityEngine;
using System.Collections;

public class UnlockLevel : MonoBehaviour {
	[Range (10,200)]
	public int neededStars;
	// Use this for initialization
	void Start () {
		int countTotalStars = PlayerPrefs.GetInt ("Category1Stars") + PlayerPrefs.GetInt ("Category2Stars") + PlayerPrefs.GetInt ("Category3Stars");
		if (countTotalStars >= neededStars) {
			this.gameObject.SetActive(false);		
		}
	}

}
