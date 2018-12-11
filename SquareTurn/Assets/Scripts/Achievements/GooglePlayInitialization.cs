using GooglePlayGames;
using GooglePlayGames.BasicApi;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GooglePlayInitialization : MonoBehaviour
{

    void Start()
    {
        // Create client configuration
        PlayGamesClientConfiguration config = new
            PlayGamesClientConfiguration.Builder()
            .Build();

        // Enable debugging output (recommended)
        PlayGamesPlatform.DebugLogEnabled = true;

        // Initialize and activate the platform
        PlayGamesPlatform.InitializeInstance(config);
        PlayGamesPlatform.Activate();

        SignIn();
    }


    private void SignIn()
    {
        PlayGamesPlatform.Instance.Authenticate(SignInCallback, false);
    }

    private void SignInCallback(bool success)
    {
        Debug.Log("Log in successful: " + success);
        Debug.Log("Signed in as: " + Social.localUser.userName);
        if (PlayerPrefs.GetInt("MigratedAchievements") != 1)
        {
            AchievementMigration.MigrateAchievements();
        }
    }
}
