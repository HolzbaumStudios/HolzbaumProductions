using UnityEngine;
using System.Collections;

public class AchievementCollection : MonoBehaviour {

	/////////////ACHIEVEMENT CLASS//////////////////////////////
	class Achievement{

		string title;
		string condition;
		Sprite image;
		int state; // 0 -> Locked, 1 -> new unlocked, 2 -> unlocked


		////SET Stuff
		//Write all the values for the achievement
		public void WriteValues(string iTitle, string iCondition){
			title = iTitle;
			condition = iCondition;
		}

		//Set the picture for the achievement
		public void SetPicture(Sprite iPicture){
			image = iPicture;
		}

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

		public Sprite GetImage(){
			return image;
		}

	}



	/////////////////////VARIABLES//////////////////////////////
	//Pictures
	
	public Sprite spriteAchievement1;
	public Sprite spriteAchievement2;
	public Sprite spriteAchievement3;
	public Sprite spriteAchievement4;


	//Class Variables
	new Achievement achievement1;
	new Achievement achievement2;
	new Achievement achievement3;
	new Achievement achievement4;





	/////////////////////START///////////////////////////////
	void Awake(){
	//SetAchievementSettings
		//Achievement1
		achievement1.WriteValues ("Plant the seeds!", "Unlock 10 trees.");
		achievement1.SetPicture (spriteAchievement1);
		achievement1.SetState(PlayerPrefs.GetInt("achievement1State"));

		//Achievement2
		achievement2.WriteValues ("Addicted to squaress!", "Start the game 50 times.");
		achievement2.SetPicture (spriteAchievement2);
		achievement1.SetState(PlayerPrefs.GetInt("achievement2State"));
	
	}



	////////////////////////FUNCTIONS//////////////////////////
	/// 
	/// Enable the achievementPanel


}
