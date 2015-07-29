using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System.Collections.Generic;

public class AchievementCollection : MonoBehaviour {

	//Assign to UserStatistics

	/////////////ACHIEVEMENT CLASS//////////////////////////////
	class Achievement{

		public string title;
		public string condition;
		int state = 0; // 0 -> Locked, 1 -> new unlocked, 2 -> unlocked


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

	//Create Lists
	List<Sprite> achievementSpriteList = new List<Sprite> ();
	List<Achievement> achievementList = new List<Achievement>(); //List for the achievement class

	//Create Class Variables
	//classvariables have to be added to the list in the awake function
	Achievement achievement1 = new Achievement("Plant the seeds!", "Unlock 10 trees.");  //list number 0
	Achievement achievement2 = new Achievement("Addicted to squares!", "Start the game 50 times."); //list number 1


	




	/////////////////////////START/////////////////////////////
	/// 
	void Awake(){
		//Initialize the class List
		achievementList.Add(achievement1);
		achievementList.Add(achievement2);

		//Initialize the sprite list
		achievementSpriteList.Add (spriteAchievement1);
		achievementSpriteList.Add (spriteAchievement2);


		//Get the state for all achievements at the beginning
		for (int i = 0; i < achievementList.Count; i++)
		{
			string prefabName = "Achievement" + i + "State";
			Debug.Log (prefabName);
			achievementList[i].SetState (PlayerPrefs.GetInt (prefabName));
		}


		achievementList [0].SetState (2); //--> just for testing purposes
		//achievementList [1].SetState (1); //--> just for testing purposes
	}

	////////////////////////FUNCTIONS//////////////////////////
	/// 
	/// Change the Values of the achievement panel
	public void SetAchievementWindow(GameObject achievementPanel){
		int achievementNumber = GetNextAchievement (); //Call function to check which achievement has been unlocked


		if(achievementNumber != 100)
		{ 
			achievementPanel.SetActive (true);
			achievementPanel.GetComponent<Animation>().Play ();

			GameObject achievementImage = achievementPanel.transform.FindChild ("AchievementImage").gameObject;
			GameObject achievementText = achievementPanel.transform.FindChild ("AchievementText").gameObject;

			achievementImage.GetComponent<Image>().sprite = achievementSpriteList[achievementNumber];
			achievementText.GetComponent<Text>().text = achievementList[achievementNumber].GetTitle();
		}
		else
		{
			PlayerPrefs.SetInt ("NewAchievement", 0);
		}
	}

	//Look for achievements with the achievement state = 1
	int GetNextAchievement(){
		int returnValue = 100;

		for(int i = 0; i < achievementList.Count; i++){
			if(achievementList[i].GetState() == 1){
				returnValue = i;
				achievementList[i].SetState(2);
				i = achievementList.Count;
			}
		}

		return returnValue; //if value 100 is returned, no further achievements are displayed
	}


	///Close achievement panel
	//If the player clicks ok, this function is run
	public void CloseAchievementPanel(){
		GameObject achievementPanel = GameObject.Find ("AchievementPanel");
		achievementPanel.SetActive (false);
		SetAchievementWindow(achievementPanel); //Call the function again, to determine if there are more unlocked achievements
	}



	//Set the achievements on the AchievementScene to Unlocked
	//Script is triggered by the script PrepareAchievementScene
	public void PrepareAchievementScene(){

		int numberOfAchievements = achievementList.Count;
		Transform achievementContainer = GameObject.Find ("AchievementContainer").transform;

		for (int i = 0; i < numberOfAchievements; i++) {
			if(achievementList[i].GetState() == 2){ //If achievement has been unlocked
				string panelName = "ShowAchievementPanel" + i;
				Transform panelObject = achievementContainer.FindChild (panelName).transform;
				GameObject lockedPanel = panelObject.FindChild("Locked").gameObject; //Find the locked component
				lockedPanel.SetActive (false);
			}
		}

	}

}
