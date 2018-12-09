using GooglePlayGames;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GooglePlayAchievements : MonoBehaviour {

    public static readonly string A1_PLANTING_THE_SEED = "CgkIyteA-dYZEAIQAA";
    public static readonly string A2_GROWING_STEM = "CgkIyteA-dYZEAIQAQ";
    public static readonly string A3_TIME_TO_BLOSSOM = "CgkIyteA-dYZEAIQAg";
    public static readonly string A4_CLIMBING_TREE = "CgkIyteA-dYZEAIQAw";
    public static readonly string A5_FLOWER_FIELD = "CgkIyteA-dYZEAIQBA";
    public static readonly string A6_RAINFOREST_DRYER = "CgkIyteA-dYZEAIQBQ";
    public static readonly string A7_CHERRY_BLOSSOM_BLUES = "CgkIyteA-dYZEAIQBg";
    public static readonly string A8_FOREST_OF_MOUNTAINS = "CgkIyteA-dYZEAIQBw";
    public static readonly string A9_FIRST_STEPS = "CgkIyteA-dYZEAIQCA";
    public static readonly string A10_AMATEUR = "CgkIyteA-dYZEAIQCQ";
    public static readonly string A11_CHALLENGER = "CgkIyteA-dYZEAIQCg";
    public static readonly string A12_BLACKBELT = "CgkIyteA-dYZEAIQCw";
    public static readonly string A13_TURNAROUND = "CgkIyteA-dYZEAIQDA";
    public static readonly string A14_TURNING_TABLES = "CgkIyteA-dYZEAIQDQ";
    public static readonly string A15_FLIPPING_NINJA = "CgkIyteA-dYZEAIQDg";
    public static readonly string A16_CHILD = "CgkIyteA-dYZEAIQDw";
    public static readonly string A17_ADULT = "CgkIyteA-dYZEAIQEA";
    public static readonly string A18_VETERAN = "CgkIyteA-dYZEAIQEQ";

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
        if (PlayGamesPlatform.Instance.localUser.authenticated)
        {
            PlayGamesPlatform.Instance.ShowAchievementsUI();
        }
        else
        {
            Debug.Log("Cannot show Achievements, not logged in");
        }
    }
}
