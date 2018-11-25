using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.Analytics;

public class UnlockLevel : MonoBehaviour {
	[Range (10,200)]
	public int neededStars;
	public GameObject levelUnlocked;
	public string levelUnlockedTitle;
	[TextArea(2,2)]
	public string levelUnlockedText;
	public Sprite levelUnlockedImage;
	public string levelPackNumber;
	// Use this for initialization
	void Start () {
		//Debugging
		//PlayerPrefs.SetInt ("levelPack2Unlocked", 0);
		//PlayerPrefs.SetInt ("levelPack3Unlocked", 0);
		//-------

		int levelPackUnlocked = PlayerPrefs.GetInt ("levelPack"+levelPackNumber+"Unlocked");
		if (levelPackUnlocked != 1) {
			int countTotalStars = PlayerPrefs.GetInt ("Category1Stars") + PlayerPrefs.GetInt ("Category2Stars") + PlayerPrefs.GetInt ("Category3Stars") + PlayerPrefs.GetInt ("Category4Stars");
			if (countTotalStars >= neededStars) {
					LevelUnlock ();
			}
		}
		else {
			this.gameObject.SetActive(false);
            this.transform.parent.GetComponent<Button>().enabled = true;
        }
	}

	void LevelUnlock () {
		levelUnlocked.transform.Find ("LevelUnlockedTitle").GetComponent<Text> ().text = levelUnlockedTitle;
		levelUnlocked.transform.Find ("LevelUnlockedText").GetComponent<Text> ().text = levelUnlockedText;
		levelUnlocked.transform.Find ("LevelUnlockedImage").GetComponent<Image> ().sprite = levelUnlockedImage;
		levelUnlocked.SetActive(true);
		string playerPrefName = "levelPack" + levelPackNumber + "Unlocked";
		PlayerPrefs.SetInt (playerPrefName, 1);
		//Update Analytics
		Analytics.CustomEvent(playerPrefName, new Dictionary<string, object>{});
        this.gameObject.SetActive(false);
        this.transform.parent.GetComponent<Button>().enabled = true;
	}

}
