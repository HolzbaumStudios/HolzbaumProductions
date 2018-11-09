using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class DisplayHandler : MonoBehaviour
{


    public bool debugSimulateLandscape = false; //This variable is only used to simluate the rotation on the pc
    public GameObject portraitCanvas;
    private bool setToPortrait = false; //Used to check, that functions on screen orientation change only occur once


    void Update()
    {
        SetDisplayMode();
    }

    void SetDisplayMode()
    {
#if UNITY_EDITOR

            debugSimulateLandscape = false;

#endif

        //--What happens before changing
        if (SceneManager.GetActiveScene().name == "levelMenu")
        {
            //SetLevelMenuCategorySlider(true);
        }
        if (SceneManager.GetActiveScene().name == "startMenu")
        {
            SetLevelMusic(false);
        }

        SetScreenOrientation();

        //--What happens after changing
        //Only on levelMenu -- Set correct category
        if (SceneManager.GetActiveScene().name == "levelMenu")
        {
            SetLevelMenu(false);
        }

        setToPortrait = true;   
    }

    //Enable/disable the canvas based on the screen orientation
    void SetScreenOrientation()
    {
        portraitCanvas.SetActive(true);
    }


    //Set the settings for the levelMenu
    void SetLevelMenu(bool setLandscape)
    {
        int activeCategory = PlayerPrefs.GetInt("ActiveCategory");
        GameObject levelChoice = portraitCanvas.transform.Find("LevelChoice").gameObject;

        if (activeCategory > 0)
        {
            levelChoice.GetComponent<MenuScript>().ChooseCategory(activeCategory);
            levelChoice.GetComponent<MenuScript>().SetSliderPosition();
        }
        else
        {
            levelChoice.GetComponent<MenuScript>().DisableAllCategories();
        }
    }

    void SetLevelMusic(bool setLandscape)
    {
        GameObject musicButton; // Das ist der Music Button
        GameObject musicBackground; // Da hängt der Skript MuiscOnOff dran (inkl. Status des Buttons)
        bool statusMusicButton; // Der aktuelle Status

        musicBackground = GameObject.Find("Music_Background").gameObject;
        if (PlayerPrefs.GetString("gameMusic") != "Off")
        {
            statusMusicButton = true;
        }
        else
        {
            statusMusicButton = false;
        }
        //statusMusicButton = musicBackground.GetComponent<musicOnOff>().status;


        Transform imageBackground = portraitCanvas.transform.Find("Image_Background");
        musicButton = imageBackground.Find("SquareImage_Music").gameObject;
        TurnButton(musicButton, statusMusicButton);
    }

    public void TurnButton(GameObject musicButton, bool status)
    {
        GameObject squareMusicButton = musicButton;

        if (status == false)
        {
            squareMusicButton.GetComponent<UnityEngine.UI.Image>().color = new Color32(131, 139, 139, 255);
            squareMusicButton.transform.Find("DisabledButton").gameObject.SetActive(true);
        }
        else if (status == true)
        {
            squareMusicButton.GetComponent<UnityEngine.UI.Image>().color = new Color32(72, 120, 168, 255);
            squareMusicButton.transform.Find("DisabledButton").gameObject.SetActive(false);
        }
    }
}
