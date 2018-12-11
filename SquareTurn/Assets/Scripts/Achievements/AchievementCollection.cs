using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System.Collections.Generic;
using UnityEngine.Analytics;

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
	public Sprite spriteAchievement0;
	public Sprite spriteAchievement1;
	public Sprite spriteAchievement2;
	public Sprite spriteAchievement3;
	public Sprite spriteAchievement4;
	public Sprite spriteAchievement5;
	public Sprite spriteAchievement6;
	public Sprite spriteAchievement7;
	public Sprite spriteAchievement8;
	public Sprite spriteAchievement9;
	public Sprite spriteAchievement10;
	public Sprite spriteAchievement11;
	public Sprite spriteAchievement12;
	public Sprite spriteAchievement13;
	public Sprite spriteAchievement14;
	public Sprite spriteAchievement15;
    public Sprite spriteAchievement16;
    public Sprite spriteAchievement17;

    public string[] achievementLogoLink;

	//Create Lists
	List<Sprite> achievementSpriteList = new List<Sprite> ();
	List<Achievement> achievementList = new List<Achievement>(); //List for the achievement class

	//Create Class Variables
	//classvariables have to be added to the list in the awake function
	Achievement achievement0 = new Achievement("Planting the seed", "Solve every level from pack 1");
	Achievement achievement1 = new Achievement("Growing stem", "Get all the stars in pack 1");
	Achievement achievement2 = new Achievement("Time to blossom", "Solve every level from pack 2"); 
	Achievement achievement3 = new Achievement("Climbing tree", "Get all the stars in pack 2"); 
	Achievement achievement4 = new Achievement("Flowerfield", "Solve every level from pack 3"); 
	Achievement achievement5 = new Achievement("Rainforest dryer", "Get all the stars in pack 3");
    Achievement achievement16 = new Achievement("Cherry blossom blues", "Solve every level from pack 4");
    Achievement achievement17 = new Achievement("Forest of mountains", "Get all the stars in pack 4");

    Achievement achievement6 = new Achievement("First steps", "Solve 5 levels");
	Achievement achievement7 = new Achievement("Amateur", "Solve 20 levels"); 
	Achievement achievement8 = new Achievement("Challenger", "Solve 40 levels"); 
	Achievement achievement9 = new Achievement("Blackbelt", "Solve 72 levels");

	Achievement achievement10 = new Achievement("Turnaround", "Turn 200 tiles"); 
	Achievement achievement11 = new Achievement("Turning tables", "Turn 1000 tiles"); 
	Achievement achievement12 = new Achievement("Flippin' Ninja", "Turn 5000 tiles");

	Achievement achievement13 = new Achievement("Child", "Start the game 5 times"); 
	Achievement achievement14 = new Achievement("Adult", "Start the game 20 times"); 
	Achievement achievement15 = new Achievement("Veteran", "Start the game 40 times"); 


	




	/////////////////////////START/////////////////////////////
	/// 
	void Awake(){
		//Initialize the class List
		achievementList.Add(achievement0);
		achievementList.Add(achievement1);
		achievementList.Add(achievement2);
		achievementList.Add(achievement3);
		achievementList.Add(achievement4);
		achievementList.Add(achievement5);
		achievementList.Add(achievement6);
		achievementList.Add(achievement7);
		achievementList.Add(achievement8);
		achievementList.Add(achievement9);
		achievementList.Add(achievement10);
		achievementList.Add(achievement11);
		achievementList.Add(achievement12);
		achievementList.Add(achievement13);
		achievementList.Add(achievement14);
		achievementList.Add(achievement15);
        achievementList.Add(achievement16);
        achievementList.Add(achievement17);

        //Initialize the sprite list
        achievementSpriteList.Add (spriteAchievement0);
		achievementSpriteList.Add (spriteAchievement1);
		achievementSpriteList.Add (spriteAchievement2);
		achievementSpriteList.Add (spriteAchievement3);
		achievementSpriteList.Add (spriteAchievement4);
		achievementSpriteList.Add (spriteAchievement5);
		achievementSpriteList.Add (spriteAchievement6);
		achievementSpriteList.Add (spriteAchievement7);
		achievementSpriteList.Add (spriteAchievement8);
		achievementSpriteList.Add (spriteAchievement9);
		achievementSpriteList.Add (spriteAchievement10);
		achievementSpriteList.Add (spriteAchievement11);
		achievementSpriteList.Add (spriteAchievement12);
		achievementSpriteList.Add (spriteAchievement13);
		achievementSpriteList.Add (spriteAchievement14);
		achievementSpriteList.Add (spriteAchievement15);
        achievementSpriteList.Add (spriteAchievement16);
        achievementSpriteList.Add (spriteAchievement17);



        //Get the state for all achievements at the beginning
        for (int i = 0; i < achievementList.Count; i++)
		{
			string prefabName = "Achievement" + i + "State";
			achievementList[i].SetState (PlayerPrefs.GetInt (prefabName));
		}


		//achievementList [0].SetState (1); //--> just for testing purposes
		//achievementList [5].SetState (1); //--> just for testing purposes
		//PlayerPrefs.SetInt ("NewAchievement", 1); //--> just for testin purposes
	}

	////////////////////////FUNCTIONS//////////////////////////
	/// 
	/// Change the Values of the achievement panel
	public void SetAchievementWindow(GameObject achievementPanel){
		int achievementNumber = GetNextAchievement (); //Call function to check which achievement has been unlocked

		if(achievementNumber != 100)
		{ 
			achievementPanel.SetActive (true);
			//Debug.Log ("Achievement active");
			//achievementPanel.GetComponent<Animation>().Play ();

			GameObject achievementImage = achievementPanel.transform.Find ("AchievementImage").gameObject;
			GameObject achievementText = achievementPanel.transform.Find ("AchievementText").gameObject;

			achievementImage.GetComponent<Image>().sprite = achievementSpriteList[achievementNumber];
			string achievementTitle = achievementList[achievementNumber].GetTitle();
			achievementText.GetComponent<Text>().text = achievementTitle;

			//Set the facebook values
			//achievementPanel.GetComponent<ShareOnFacebook>().SetAchievementInfos(achievementTitle, achievementLogoLink[achievementNumber], achievementList[achievementNumber].GetCondition());

			StartCoroutine(AnimationCountdown(6, achievementPanel));
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
				achievementList[i].SetState(2);
				string prefabName = "Achievement" + i + "State";
				PlayerPrefs.SetInt (prefabName, 2);
				//Update Analytics
				string eventName = "Achievement" + i;
				Analytics.CustomEvent(eventName, new Dictionary<string, object>{});

				returnValue = i;
				i = achievementList.Count;
			}
		}

		return returnValue; //if value 100 is returned, no further achievements are displayed
	}


	///Close achievement panel
	//If the player clicks ok, this function is run
	public void CloseAchievementPanel(GameObject achievementPanel){
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
				Transform panelObject = achievementContainer.Find (panelName).transform;
				GameObject lockedPanel = panelObject.Find("Locked").gameObject; //Find the locked component
				lockedPanel.SetActive (false);
			}
		}

	}

	//Wait a specified time of seconds, until disabling the animation panel
	IEnumerator AnimationCountdown(float seconds, GameObject achievementPanel)
	{
		yield return new WaitForSeconds(seconds);
		CloseAchievementPanel (achievementPanel);
	}

	//Functions is called to set the achievement state of a specific achievement
	public void SetLocalAchievementState(int achievementNumber, int achievementState)
	{
		achievementList [achievementNumber].SetState (achievementState);
	}

	public int GetLocalAchievementState(int achievementNumber)
	{
		return achievementList [achievementNumber].GetState ();
	}

    public void CompleteGlobalAchievement(int achievementNumber)
    {
        achievementList[achievementNumber].SetState(2);
        PlayerPrefs.SetInt("Achievement" + achievementNumber + "State", 2);
    }

    //Resets all achievements
    public void SetAchievementsBack()
	{
		for (int i = 0; i < achievementList.Count; i++)
		{
			string prefabName = "Achievement" + i + "State";
			achievementList[i].SetState (0);
			PlayerPrefs.SetInt (prefabName, 0);
		}
	}

}
