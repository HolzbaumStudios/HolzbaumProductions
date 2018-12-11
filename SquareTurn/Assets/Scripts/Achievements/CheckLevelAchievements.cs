using UnityEngine;
using System.Collections;

public class CheckLevelAchievements : MonoBehaviour {

	//Script to check achievements 0 to 5

	// Check the number of level stars
	void Start () {

		//Get the variabele of the last chosen level
		int lastPlayedLevel = PlayerPrefs.GetInt ("ChosenLevel");
		string playerPrefName; //PlayerPrefs names will be generated in stored in this variable
        GameObject userStatistics = GameObject.Find("UserStatistics");
        AchievementCollection achievementCollection = userStatistics.GetComponent<AchievementCollection>();

        if (lastPlayedLevel >= 100 && lastPlayedLevel < 200)
		{
			if(PlayerPrefs.GetInt("Achievement0State") == 0)
			{
				bool reachedOneStar = true;

				for(int i = 100; i <= 123; i++)
				{
					playerPrefName = LevelStatistics.STARS_PER_LEVEL_PREFAB + i;
					if(PlayerPrefs.GetInt (playerPrefName) < 1)
				    {
						reachedOneStar = false;
					}
				}

				if(reachedOneStar == true)
				{
                    GooglePlayAchievements.UnlockAchiemevent(GooglePlayAchievements.A1_PLANTING_THE_SEED);
                    achievementCollection.CompleteGlobalAchievement(0);

                    //Check if also reached all three stars in the same moment
                    bool reachedThreeStars = true;
					for(int i = 100; i <= 123; i++)
					{
						playerPrefName = LevelStatistics.STARS_PER_LEVEL_PREFAB + i;
						if(PlayerPrefs.GetInt (playerPrefName) < 3)
						{
							reachedThreeStars = false;
						}
					}
					if(reachedThreeStars == true)
					{
                        GooglePlayAchievements.UnlockAchiemevent(GooglePlayAchievements.A2_GROWING_STEM);
                        achievementCollection.CompleteGlobalAchievement(1);
                    }
					//--END CHECK 3 stars
				}
			}
			else if(PlayerPrefs.GetInt ("Achievement1State") == 0)
			{
				bool reachedThreeStars = true;
				
				for(int i = 100; i <= 123; i++)
				{
					playerPrefName = LevelStatistics.STARS_PER_LEVEL_PREFAB + i;
					if(PlayerPrefs.GetInt (playerPrefName) < 3)
					{
						reachedThreeStars = false;
					}
				}
				
				if(reachedThreeStars == true)
				{
                    GooglePlayAchievements.UnlockAchiemevent(GooglePlayAchievements.A2_GROWING_STEM);
                    achievementCollection.CompleteGlobalAchievement(1);
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
					playerPrefName = LevelStatistics.STARS_PER_LEVEL_PREFAB + i;
					if(PlayerPrefs.GetInt (playerPrefName) < 1)
					{
						reachedOneStar = false;
					}
				}
				
				if(reachedOneStar == true)
				{
                    GooglePlayAchievements.UnlockAchiemevent(GooglePlayAchievements.A3_TIME_TO_BLOSSOM);
                    achievementCollection.CompleteGlobalAchievement(2);

                    //Check if also reached all three stars in the same moment
                    bool reachedThreeStars = true;
					for(int i = 200; i <= 223; i++)
					{
						playerPrefName = LevelStatistics.STARS_PER_LEVEL_PREFAB + i;
						if(PlayerPrefs.GetInt (playerPrefName) < 3)
						{
							reachedThreeStars = false;
						}
					}
					if(reachedThreeStars == true)
					{
                        GooglePlayAchievements.UnlockAchiemevent(GooglePlayAchievements.A4_CLIMBING_TREE);
                        achievementCollection.CompleteGlobalAchievement(3);
                    }
					//--END CHECK 3 stars
				}
			}
			else if(PlayerPrefs.GetInt ("Achievement3State") == 0)
			{
				bool reachedThreeStars = true;
				
				for(int i = 200; i <= 223; i++)
				{
					playerPrefName = LevelStatistics.STARS_PER_LEVEL_PREFAB + i;
					if(PlayerPrefs.GetInt (playerPrefName) < 3)
					{
						reachedThreeStars = false;
					}
				}
				
				if(reachedThreeStars == true)
				{
                    GooglePlayAchievements.UnlockAchiemevent(GooglePlayAchievements.A4_CLIMBING_TREE);
                    achievementCollection.CompleteGlobalAchievement(3);
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
					playerPrefName = LevelStatistics.STARS_PER_LEVEL_PREFAB + i;
					if(PlayerPrefs.GetInt (playerPrefName) < 1)
					{
						reachedOneStar = false;
					}
				}
				
				if(reachedOneStar == true)
				{
                    GooglePlayAchievements.UnlockAchiemevent(GooglePlayAchievements.A5_FLOWER_FIELD);
                    achievementCollection.CompleteGlobalAchievement(4);

                    //Check if also reached all three stars in the same moment
                    bool reachedThreeStars = true;
					for(int i = 300; i <= 323; i++)
					{
						playerPrefName = LevelStatistics.STARS_PER_LEVEL_PREFAB + i;
						if(PlayerPrefs.GetInt (playerPrefName) < 3)
						{
							reachedThreeStars = false;
						}
					}
					if(reachedThreeStars == true)
					{
                        GooglePlayAchievements.UnlockAchiemevent(GooglePlayAchievements.A6_RAINFOREST_DRYER);
                        achievementCollection.CompleteGlobalAchievement(5);
                    }
					//--END CHECK 3 stars
				}
			}
			else if(PlayerPrefs.GetInt ("Achievement5State") == 0)
			{
				bool reachedThreeStars = true;
				
				for(int i = 300; i <= 323; i++)
				{
					playerPrefName = LevelStatistics.STARS_PER_LEVEL_PREFAB + i;
					if(PlayerPrefs.GetInt (playerPrefName) < 3)
					{
						reachedThreeStars = false;
					}
				}
				
				if(reachedThreeStars == true)
				{
                    GooglePlayAchievements.UnlockAchiemevent(GooglePlayAchievements.A6_RAINFOREST_DRYER);
                    achievementCollection.CompleteGlobalAchievement(5);
				}
			}
		}

        //Category 4
        if (lastPlayedLevel >= 400 && lastPlayedLevel < 500)
        {
            if (PlayerPrefs.GetInt("Achievement16State") == 0)
            {
                bool reachedOneStar = true;

                for (int i = 400; i <= 423; i++)
                {
                    playerPrefName = LevelStatistics.STARS_PER_LEVEL_PREFAB + i;
                    if (PlayerPrefs.GetInt(playerPrefName) < 1)
                    {
                        reachedOneStar = false;
                    }
                }

                if (reachedOneStar == true)
                {
                    GooglePlayAchievements.UnlockAchiemevent(GooglePlayAchievements.A7_CHERRY_BLOSSOM_BLUES);
                    achievementCollection.CompleteGlobalAchievement(16);

                    //Check if also reached all three stars in the same moment
                    bool reachedThreeStars = true;
                    for (int i = 400; i <= 423; i++)
                    {
                        playerPrefName = LevelStatistics.STARS_PER_LEVEL_PREFAB + i;
                        if (PlayerPrefs.GetInt(playerPrefName) < 3)
                        {
                            reachedThreeStars = false;
                        }
                    }
                    if (reachedThreeStars == true)
                    {
                        GooglePlayAchievements.UnlockAchiemevent(GooglePlayAchievements.A8_FOREST_OF_MOUNTAINS);
                        achievementCollection.CompleteGlobalAchievement(17);
                    }
                    //--END CHECK 3 stars
                }
            }
            else if (PlayerPrefs.GetInt("Achievement17State") == 0)
            {
                bool reachedThreeStars = true;

                for (int i = 400; i <= 423; i++)
                {
                    playerPrefName = LevelStatistics.STARS_PER_LEVEL_PREFAB + i;
                    if (PlayerPrefs.GetInt(playerPrefName) < 3)
                    {
                        reachedThreeStars = false;
                    }
                }

                if (reachedThreeStars == true)
                {
                    GooglePlayAchievements.UnlockAchiemevent(GooglePlayAchievements.A8_FOREST_OF_MOUNTAINS);
                    achievementCollection.CompleteGlobalAchievement(17);
                }
            }
        }
    }

}
