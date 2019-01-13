using UnityEngine;
using System.Collections;

public class CheckAchievementsAtStart : MonoBehaviour {

    public static void CheckStartAchievement()
    {
        GameObject userStatistics = GameObject.Find("UserStatistics");
        GameObject achievementPanel = GameObject.Find("AchievementPanel");

        AchievementCollection achievementCollection = userStatistics.GetComponent<AchievementCollection>();


        int numberOfAppStarts = PlayerPrefs.GetInt("NumberOfAppStarts");

        if (achievementCollection.GetLocalAchievementState(13) == 0)
        {
            if (numberOfAppStarts >= 5)
            {
                achievementCollection.CompleteGlobalAchievement(13);
                GooglePlayAchievements.UnlockAchiemevent(GooglePlayAchievements.A16_CHILD);
            }
        }
        else if (achievementCollection.GetLocalAchievementState(14) == 0)
        {

            if (numberOfAppStarts >= 20)
            {
                achievementCollection.CompleteGlobalAchievement(14);
                GooglePlayAchievements.UnlockAchiemevent(GooglePlayAchievements.A17_ADULT);
            }
        }
        else if (achievementCollection.GetLocalAchievementState(15) == 0)
        {
            if (numberOfAppStarts >= 40)
            {
                userStatistics.GetComponent<AchievementCollection>().SetLocalAchievementState(15, 1);
                PlayerPrefs.SetInt("NewAchievement", 1); //Set the newAchievement playerPref always after setting the achievementStates
                achievementPanel.GetComponent<CheckForAchievements>().CheckAchievements();

                achievementCollection.CompleteGlobalAchievement(15);
                GooglePlayAchievements.UnlockAchiemevent(GooglePlayAchievements.A18_VETERAN);
            }
        }
    }
}
