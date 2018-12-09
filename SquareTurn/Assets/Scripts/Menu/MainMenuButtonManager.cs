using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuButtonManager : MonoBehaviour {

    musicOnOff musicOnOff;

    [SerializeField]
    private GameObject soundButton;

    public void Start()
    {
        musicOnOff = GameObject.Find("Music_Background").GetComponent<musicOnOff>();
    }

    public void LoadScene(string sceneName)
    {
        if("levelMenu".Equals(sceneName))
        {
            PlayerPrefs.SetInt("ActiveCategory", 0); //Set the the levelcategory to none (with this, the category selection is displayed)    
        }
        SceneManager.LoadScene(sceneName);
    }

    public void SoundButton()
    {
        musicOnOff.TurnButton(soundButton);
    }

    public void LoadAchievements()
    {
        GooglePlayAchievements.ShowAchievementsUI();
    }
}
