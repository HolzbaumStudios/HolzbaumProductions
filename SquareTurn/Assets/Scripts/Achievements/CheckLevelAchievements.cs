using UnityEngine;
using System.Collections;

public class CheckLevelAchievements : MonoBehaviour {

	//Script to check achievements 0 to 5

	// Check the number of level stars
	void Start () {

		//Get the variabele of the last chosen level
		int lastPlayedLevel = PlayerPrefs.GetInt ("ChosenLevel");
		string playerPrefName; //PlayerPrefs names will be generated in stored in this variable

		if(lastPlayedLevel >= 100 && lastPlayedLevel < 200)
		{
			if(PlayerPrefs.GetInt("Achievement0State") == 0)
			{
				bool reachedOneStar = true;

				for(int i = 100; i <= 123; i++)
				{
					playerPrefName = "StarsLevel" + i;
					if(PlayerPrefs.GetInt (playerPrefName) < 1)
				    {
						reachedOneStar = false;
					}
				}

				if(reachedOneStar == true)
				{
					GameObject userStatistics = GameObject.Find ("UserStatistics");
					userStatistics.GetComponent<AchievementCollection>().SetLocalAchievementState (0,1);
					PlayerPrefs.SetInt ("NewAchievement", 1);

					//Check if also reached all three stars in the same moment
					bool reachedThreeStars = true;
					for(int i = 100; i <= 123; i++)
					{
						playerPrefName = "StarsLevel" + i;
						if(PlayerPrefs.GetInt (playerPrefName) < 3)
						{
							reachedThreeStars = false;
						}
					}
					if(reachedThreeStars == true)
					{
						userStatistics.GetComponent<AchievementCollection>().SetLocalAchievementState (1,1);
					}
					//--END CHECK 3 stars
					GameObject achievementPanel = GameObject.Find ("AchievementPanel");
					achievementPanel.GetComponent<CheckForAchievements> ().CheckAchievements ();
				}
			}
			else if(PlayerPrefs.GetInt ("Achievement1State") == 0)
			{
				bool reachedThreeStars = true;
				
				for(int i = 100; i <= 123; i++)
				{
					playerPrefName = "StarsLevel" + i;
					if(PlayerPrefs.GetInt (playerPrefName) < 3)
					{
						reachedThreeStars = false;
					}
				}
				
				if(reachedThreeStars == true)
				{
					GameObject userStatistics = GameObject.Find ("UserStatistics");
					userStatistics.GetComponent<AchievementCollection>().SetLocalAchievementState (1,1);
					PlayerPrefs.SetInt ("NewAchievement", 1);
					
					GameObject achievementPanel = GameObject.Find ("AchievementPanel");
					achievementPanel.GetComponent<CheckForAchievements> ().CheckAchievements ();
				}
			}
		}

		if(lastPlayedLevel >= 200 && lastPlayedLevel < 300)
		{
			if(PlayerPrefs.GetInt("Achievement2State") == 0)
			{
				bool reachedOneStar = true;
				
				for(int i = 200; i <= 223; i++)
				{
					playerPrefName = "StarsLevel" + i;
					if(PlayerPrefs.GetInt (playerPrefName) < 1)
					{
						reachedOneStar = false;
					}
				}
				
				if(reachedOneStar == true)
				{
					GameObject userStatistics = GameObject.Find ("UserStatistics");
					userStatistics.GetComponent<AchievementCollection>().SetLocalAchievementState (2,1);
					PlayerPrefs.SetInt ("NewAchievement", 1);

					//Check if also reached all three stars in the same moment
					bool reachedThreeStars = true;
					for(int i = 200; i <= 223; i++)
					{
						playerPrefName = "StarsLevel" + i;
						if(PlayerPrefs.GetInt (playerPrefName) < 3)
						{
							reachedThreeStars = false;
						}
					}
					if(reachedThreeStars == true)
					{
						userStatistics.GetComponent<AchievementCollection>().SetLocalAchievementState (3,1);
					}
					//--END CHECK 3 stars
					
					GameObject achievementPanel = GameObject.Find ("AchievementPanel");
					achievementPanel.GetComponent<CheckForAchievements> ().CheckAchievements ();
				}
			}
			else if(PlayerPrefs.GetInt ("Achievement3State") == 0)
			{
				bool reachedThreeStars = true;
				
				for(int i = 200; i <= 223; i++)
				{
					playerPrefName = "StarsLevel" + i;
					if(PlayerPrefs.GetInt (playerPrefName) < 3)
					{
						reachedThreeStars = false;
					}
				}
				
				if(reachedThreeStars == true)
				{
					GameObject userStatistics = GameObject.Find ("UserStatistics");
					userStatistics.GetComponent<AchievementCollection>().SetLocalAchievementState (3,1);
					PlayerPrefs.SetInt ("NewAchievement", 1);
					
					GameObject achievementPanel = GameObject.Find ("AchievementPanel");
					achievementPanel.GetComponent<CheckForAchievements> ().CheckAchievements ();
				}
			}
		}

		if(lastPlayedLevel >= 300 && lastPlayedLevel < 400)
		{
			if(PlayerPrefs.GetInt("Achievement4State") == 0)
			{
				bool reachedOneStar = true;
				
				for(int i = 300; i <= 323; i++)
				{
					playerPrefName = "StarsLevel" + i;
					if(PlayerPrefs.GetInt (playerPrefName) < 1)
					{
						reachedOneStar = false;
					}
				}
				
				if(reachedOneStar == true)
				{
					GameObject userStatistics = GameObject.Find ("UserStatistics");
					userStatistics.GetComponent<AchievementCollection>().SetLocalAchievementState (4,1);
					PlayerPrefs.SetInt ("NewAchievement", 1);

					//Check if also reached all three stars in the same moment
					bool reachedThreeStars = true;
					for(int i = 300; i <= 323; i++)
					{
						playerPrefName = "StarsLevel" + i;
						if(PlayerPrefs.GetInt (playerPrefName) < 3)
						{
							reachedThreeStars = false;
						}
					}
					if(reachedThreeStars == true)
					{
						userStatistics.GetComponent<AchievementCollection>().SetLocalAchievementState (5,1);
					}
					//--END CHECK 3 stars
					
					GameObject achievementPanel = GameObject.Find ("AchievementPanel");
					achievementPanel.GetComponent<CheckForAchievements> ().CheckAchievements ();
				}
			}
			else if(PlayerPrefs.GetInt ("Achievement5tate") == 0)
			{
				bool reachedThreeStars = true;
				
				for(int i = 300; i <= 323; i++)
				{
					playerPrefName = "StarsLevel" + i;
					if(PlayerPrefs.GetInt (playerPrefName) < 3)
					{
						reachedThreeStars = false;
					}
				}
				
				if(reachedThreeStars == true)
				{
					GameObject userStatistics = GameObject.Find ("UserStatistics");
					userStatistics.GetComponent<AchievementCollection>().SetLocalAchievementState (5,1);
					PlayerPrefs.SetInt ("NewAchievement", 1);
					
					GameObject achievementPanel = GameObject.Find ("AchievementPanel");
					achievementPanel.GetComponent<CheckForAchievements> ().CheckAchievements ();
				}
			}
		}
	}

}
