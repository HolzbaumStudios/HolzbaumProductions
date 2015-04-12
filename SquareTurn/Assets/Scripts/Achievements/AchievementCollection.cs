using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class AchievementCollection : MonoBehaviour {

	/////////////ACHIEVEMENT CLASS//////////////////////////////
	class Achievement{

		public string title;
		public string condition;
		int state; // 0 -> Locked, 1 -> new unlocked, 2 -> unlocked


		public Achievement(string tit, string cond){
			title = tit;
			condition = cond;
		}

		////SET Stuff
		//Get the state from the prefab
		public void SetState(int newState){
			state = newState;
		}

		////Get Stuff
		public string GetTitle(){
			return title;
		}

		public string GetCondition(){
			return condition;
		}

		public int GetState(){
			return state;
		}


	}



	/////////////////////VARIABLES//////////////////////////////
	//Pictures
	
	public Sprite spriteAchievement1;
	public Sprite spriteAchievement2;
	public Sprite spriteAchievement3;
	public Sprite spriteAchievement4;


	//Create Class Variables
	Achievement achievement1 = new Achievement("Plant the seeds!", "Unlock 10 trees.");
	Achievement achievement2 = new Achievement("Addicted to squares!", "Start the game 50 times.");
	//Achievement achievement3 = new Achievement("Plant the seeds!", "Unlock 10 trees.");
	//Achievement achievement4 = new Achievement("Plant the seeds!", "Unlock 10 trees.");



	/////////////////////////START/////////////////////////////
	/// 
	void Awake(){
		achievement1.SetState (PlayerPrefs.GetInt("Achievement1State"));
		achievement2.SetState (PlayerPrefs.GetInt("Achievement2State"));
	}

	////////////////////////FUNCTIONS//////////////////////////
	/// 
	/// Change the Values of the achievement panel
	public void SetAchievementWindow(GameObject achievementPanel){
		achievementPanel.SetActive (true);
		achievementPanel.GetComponent<Animation>().Play ();

		GameObject achievementImage = achievementPanel.transform.FindChild ("AchievementImage").gameObject;
		GameObject achievementText = achievementPanel.transform.FindChild ("AchievementText").gameObject;

		achievementImage.GetComponent<Image>().sprite = spriteAchievement1;
		achievementText.GetComponent<Text>().text = achievement2.GetTitle();

		Debug.Log ("Ausgeführt!");

	}

}
