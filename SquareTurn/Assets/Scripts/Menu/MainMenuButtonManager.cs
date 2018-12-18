using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainMenuButtonManager : MonoBehaviour {

    [SerializeField]
    private GameObject soundButton;
    private Image soundButtonImage;
    private GameObject disabledSoundButtonElement;

    public void Start()
    {
        soundButtonImage = soundButton.GetComponent<UnityEngine.UI.Image>();
        disabledSoundButtonElement = soundButton.transform.Find("DisabledButton").gameObject;
        if (PlayerPrefs.GetString("gameMusic") == "Off")
        {
            SetButtonGUIDisabled();
        }
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
        MusicManager.GetInstance().TurnButton(soundButton);
    }

    public void LoadAchievements()
    {
        GooglePlayAchievements.ShowAchievementsUI();
    }

    public void SetButtonGUIDisabled()
    {
        soundButtonImage.color = new Color32(131, 139, 139, 255);
        disabledSoundButtonElement.SetActive(true);
    }
}
