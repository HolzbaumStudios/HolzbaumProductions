using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using TMPro;
using System.Collections.Generic;

//Sets the number of achieved stars in the level catecory choice
//Assign script to the UI.Text GameObject
public class SetCategoryInfo : MonoBehaviour
{

    [SerializeField]
    private TextMeshProUGUI categoryTitleText;
    [SerializeField]
    private TextMeshProUGUI starInfoText;
    [SerializeField]
    private TextMeshProUGUI levelInfoText;
    [SerializeField]
    private Image categoryImageComponent;

    [SerializeField]
    private Button categoryButtonComponent;

    [SerializeField]
    List<Sprite> categoryImages;

    private MenuScript levelChoiceMenuScript;

    private int categoryNumber;
    private string maxStars = "72";
    private string maxLevels = "24";


    // Use this for initialization
    void Start()
    {
        string starPrefName = "Category" + categoryNumber + "Stars";
        string achievedStars = PlayerPrefs.GetInt(starPrefName).ToString();
        starInfoText.text = achievedStars + " / " + maxStars;

        string finishedLevels = LevelStatistics.GetInstance().GetNumberOfCompletedLevels(categoryNumber).ToString();
        levelInfoText.text = finishedLevels + " / " + maxLevels;

        categoryImageComponent.sprite = categoryImages[categoryNumber-1];

        SetCategoryName();
    }

    public void SetCategoryNumber(int categoryNumber)
    {
        this.categoryNumber = categoryNumber;
    }

    public void SetMenuScript(MenuScript menuScript)
    {
        this.levelChoiceMenuScript = menuScript;
        categoryButtonComponent.onClick.AddListener(() => levelChoiceMenuScript.ChooseCategory(categoryNumber));
    }

    private void SetCategoryName()
    {
        switch (categoryNumber)
        {
            case 1:
                categoryTitleText.text = "Pack 1: Testing the Waters";
                gameObject.name = "Category1Button";
                break;
            case 2:
                categoryTitleText.text = "Pack 2: New Colors";
                gameObject.name = "Category2Button";
                break;
            case 3:
                categoryTitleText.text = "Pack 3: Mastering the Path";
                gameObject.name = "Category3Button";
                break;
            case 4:
                categoryTitleText.text = "Pack 4: All Shapes and Forms";
                gameObject.name = "Category4Button";
                break;
        }
    }
}
