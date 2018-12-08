using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GooglePlayAchievements : MonoBehaviour {

	public static void UnlockAchiemevent(string id)
    {
        Social.ReportProgress(id, 100, DebugAchievementUnlocked);
    }

    private static void DebugAchievementUnlocked(bool success)
    {
        if (success)
        {
            Debug.Log("Achievement unlocked!");
        }
    }

    public static void ShowAchievementsUI()
    {
        Social.ShowAchievementsUI();
    }
}
