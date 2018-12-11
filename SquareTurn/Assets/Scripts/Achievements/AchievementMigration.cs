using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// When updating the app, the old achievements are carried over to the new google play services achievement system.
/// </summary>
public class AchievementMigration : MonoBehaviour {

	public static void MigrateAchievements() { 
        if(PlayerPrefs.GetInt("Achievement0State") > 0) 
            GooglePlayAchievements.UnlockAchiemevent(GooglePlayAchievements.A1_PLANTING_THE_SEED);

        if (PlayerPrefs.GetInt("Achievement1State") > 0)
            GooglePlayAchievements.UnlockAchiemevent(GooglePlayAchievements.A2_GROWING_STEM);

        if (PlayerPrefs.GetInt("Achievement2State") > 0)
            GooglePlayAchievements.UnlockAchiemevent(GooglePlayAchievements.A3_TIME_TO_BLOSSOM);

        if (PlayerPrefs.GetInt("Achievement3State") > 0)
            GooglePlayAchievements.UnlockAchiemevent(GooglePlayAchievements.A4_CLIMBING_TREE);

        if (PlayerPrefs.GetInt("Achievement4State") > 0)
            GooglePlayAchievements.UnlockAchiemevent(GooglePlayAchievements.A5_FLOWER_FIELD);

        if (PlayerPrefs.GetInt("Achievement5State") > 0)
            GooglePlayAchievements.UnlockAchiemevent(GooglePlayAchievements.A6_RAINFOREST_DRYER);

        if (PlayerPrefs.GetInt("Achievement6State") > 0)
            GooglePlayAchievements.UnlockAchiemevent(GooglePlayAchievements.A9_FIRST_STEPS);

        if (PlayerPrefs.GetInt("Achievement7State") > 0)
            GooglePlayAchievements.UnlockAchiemevent(GooglePlayAchievements.A10_AMATEUR);

        if (PlayerPrefs.GetInt("Achievement8State") > 0)
            GooglePlayAchievements.UnlockAchiemevent(GooglePlayAchievements.A11_CHALLENGER);

        if (PlayerPrefs.GetInt("Achievement9State") > 0)
            GooglePlayAchievements.UnlockAchiemevent(GooglePlayAchievements.A12_BLACKBELT);

        if (PlayerPrefs.GetInt("Achievement10State") > 0)
            GooglePlayAchievements.UnlockAchiemevent(GooglePlayAchievements.A13_TURNAROUND);

        if (PlayerPrefs.GetInt("Achievement11State") > 0)
            GooglePlayAchievements.UnlockAchiemevent(GooglePlayAchievements.A14_TURNING_TABLES);

        if (PlayerPrefs.GetInt("Achievement12State") > 0)
            GooglePlayAchievements.UnlockAchiemevent(GooglePlayAchievements.A15_FLIPPING_NINJA);

        if (PlayerPrefs.GetInt("Achievement13State") > 0)
            GooglePlayAchievements.UnlockAchiemevent(GooglePlayAchievements.A16_CHILD);

        if (PlayerPrefs.GetInt("Achievement14State") > 0)
            GooglePlayAchievements.UnlockAchiemevent(GooglePlayAchievements.A17_ADULT);

        if (PlayerPrefs.GetInt("Achievement15State") > 0)
            GooglePlayAchievements.UnlockAchiemevent(GooglePlayAchievements.A18_VETERAN);

        if (PlayerPrefs.GetInt("Achievement16State") > 0)
            GooglePlayAchievements.UnlockAchiemevent(GooglePlayAchievements.A7_CHERRY_BLOSSOM_BLUES);

        if (PlayerPrefs.GetInt("Achievement17State") > 0)
            GooglePlayAchievements.UnlockAchiemevent(GooglePlayAchievements.A8_FOREST_OF_MOUNTAINS);

        PlayerPrefs.SetInt("MigratedAchievements", 1);
	}
}
