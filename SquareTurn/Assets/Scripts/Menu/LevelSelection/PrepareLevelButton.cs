using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PrepareLevelButton : MonoBehaviour {

    [SerializeField]
    private Text textComponent;
    [SerializeField]
    private Button buttonComponent;
    [SerializeField]
    private ChooseLevelScript chooseLevelScript;
    [SerializeField]
    private GameObject starContainerOne;
    [SerializeField]
    private GameObject starContainerTwo;
    [SerializeField]
    private GameObject starContainerThree;

    private int levelNumberShort;
    private int levelNumberLong;
    private int categoryNumber;

    public void SetLevelNumber(int categoryNumber, int levelNumber)
    {
        this.levelNumberShort = levelNumber;
        this.levelNumberLong = (categoryNumber * 100) + levelNumberShort;

        textComponent.text = categoryNumber + "-" + (levelNumber + 1);
        textComponent.fontStyle = FontStyle.Bold;
        textComponent.resizeTextForBestFit = true;
        textComponent.resizeTextMaxSize = 140;
        textComponent.resizeTextMinSize = 20;
        textComponent.alignment = TextAnchor.MiddleCenter;

        buttonComponent.onClick.AddListener(() => chooseLevelScript.LoadLevel(levelNumberLong)); //The on click function can not be seen on the editor
    }

    public void Start()
    {
        EnableCorrectStarContainer();
    }

    private void EnableCorrectStarContainer()
    {
        string prefabName = "StarsLevel" + levelNumberLong;
        int achievedStars = PlayerPrefs.GetInt(prefabName);

        if (achievedStars == 3)
        {
            starContainerThree.SetActive(true);
        }
        else if (achievedStars == 2)
        {
            starContainerTwo.SetActive(true);
        }
        else if (achievedStars == 1)
        {
            starContainerOne.SetActive(true);
        }
    }
}
