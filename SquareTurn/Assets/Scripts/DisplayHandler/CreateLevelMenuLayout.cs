using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System;
using TMPro;

//Makes sure, that the script checkLevelAchievemnts is attached to the object
[RequireComponent(typeof(CheckLevelAchievements))]
public class CreateLevelMenuLayout : MonoBehaviour
{
    float sizeMultiplier = (1f / 1920) * Screen.height;

    /// <summary>
    /// This script has to be attached to a UI Canvas Element.
    /// It sets the correct settings for the canvas and creates all child elements for the level menu
    /// This should help with adjusting the menu on different resolutions
    /// </summary>

    public float resolutionWidth;
    public float resolutionHeight;
    public float numberColumns = 3; //How many rows with levelButtons should be displayed
    public float numberRows = 8; // How many columns with levelButtons should be displayed
    public int categroies = 4;
    public Sprite squareImage;
    public Sprite starSprite;
    public Sprite arrowSprite;
    public Sprite dotSprite;
    public Sprite[] categorySprite;
    public Sprite lockSprite;
    public Sprite crossSprite;
    public Font textFont;
    public GameObject scrollbarPrefab; //Scrollbar prefab

    [SerializeField]
    private GameObject levelButtonPrefab;
    [SerializeField]
    private GameObject categoryButtonPrefab;
    [SerializeField]
    private GameObject categoryUnlockedPrefab;
    [SerializeField]
    private GameObject numberOfStarsPrefab;

    //Private reference variables
    private GameObject scrollbarObject; //For having reference across the script
    private GameObject levelUnlockedPanel; //Reference to levelUnlockedPanel across the script
    private GameObject achievementPanel; //Reference to achievementPanel across the script
    private GameObject[] category = new GameObject[4];
    private float screenRatio;

    void Awake()
    {

#if UNITY_EDITOR
        resolutionHeight = Screen.height;
        resolutionWidth = Screen.width;
#else

        if(Screen.height > Screen.width)
        {
            resolutionHeight = Screen.height;
            resolutionWidth = Screen.width;
        }
        else
        {
            resolutionHeight = Screen.width;
            resolutionWidth = Screen.height;
        }

#endif

        CreateLayout();
    }

    public void CreateLayout()
    {
        Debug.Log(Screen.width + "x" + Screen.height);
        if (resolutionHeight > resolutionWidth)
        {
            screenRatio = resolutionHeight / resolutionWidth;
        }
        else
        {
            screenRatio = resolutionWidth / resolutionHeight;
        }
        //Set all canvas settings
        CanvasScaler scalerComponent;
        scalerComponent = GetComponent<CanvasScaler>();
        scalerComponent.uiScaleMode = CanvasScaler.ScaleMode.ScaleWithScreenSize;
        scalerComponent.referenceResolution = new Vector2(resolutionWidth, resolutionHeight);

        //-----Create LevelChoice Panel-----
        GameObject levelChoice = new GameObject("LevelChoice");
        levelChoice.transform.SetParent(this.gameObject.transform);
        levelChoice.layer = LayerMask.NameToLayer("UI");
        levelChoice.AddComponent<CanvasRenderer>();
        levelChoice.AddComponent<RectTransform>();
        //Set rect transform size
        RectTransform levelChoiceRect = levelChoice.GetComponent<RectTransform>();
        levelChoiceRect.offsetMax = new Vector2(0, 0);
        levelChoiceRect.offsetMin = new Vector2(0, 0);
        levelChoiceRect.localScale = new Vector3(1, 1, 1);
        //Set rect transform anchors
        levelChoiceRect.anchorMin = new Vector2(0, 0);
        levelChoiceRect.anchorMax = new Vector2(1, 1);
        levelChoiceRect.pivot = new Vector2(0.5f, 0.5f);


        //-----Create scrollbar------
        scrollbarObject = Instantiate(scrollbarPrefab) as GameObject;
        scrollbarObject.transform.SetParent(levelChoice.transform);
        scrollbarObject.name = "Scrollbar";
        Scrollbar scrollbar = scrollbarObject.GetComponent<Scrollbar>();

        //-----Create categories-----
        for (int cat = 1; cat <= categroies; cat++)
        {
            category[cat - 1] = CreateCategory(cat, levelChoice.transform);
        }

        //------Create level unlocked panel-----
        CreateLevelUnlocked(this.gameObject.transform);

        //-----Create Category Choice Panel-----
        GameObject categoryChoice = CreateCategoryChoice(levelChoice);

        //----Add script for level rect-----
        DetectScrolling scrollScript = levelChoice.AddComponent<DetectScrolling>();

        //-----Add level choice scroll rect and menu script-----
        //Add scrollrect
        ScrollRect scrollRect = levelChoice.AddComponent<ScrollRect>();
        scrollRect.horizontal = false;
        scrollRect.vertical = true;
        scrollRect.movementType = ScrollRect.MovementType.Elastic;
        scrollRect.horizontalScrollbar = scrollbar;
        scrollRect.onValueChanged.AddListener(delegate { scrollScript.DetectScrollChange(); });
        //Add script
        MenuScript menuScript = levelChoice.GetComponent<MenuScript>();
        menuScript.categoryChoice = categoryChoice;
        menuScript.category1 = category[0];
        menuScript.category2 = category[1];
        menuScript.category3 = category[2];
        menuScript.category4 = category[3];
        menuScript.categorySlider = scrollbarObject;
    }

    //Create a category
    //This function takes the category number and the parent to which the categories have to be attached, as argument
    GameObject CreateCategory(int cat, Transform parent)
    {
        //Create Category Object
        GameObject category = new GameObject("Category" + cat);
        category.transform.SetParent(parent);
        category.SetActive(false);
        category.layer = LayerMask.NameToLayer("UI");
        category.AddComponent<CanvasRenderer>();
        category.AddComponent<RectTransform>();
        RectTransform categoryRect = category.GetComponent<RectTransform>();
        //Set rect transform anchors
        categoryRect.anchorMin = new Vector2(0.5f, 0.5f);
        categoryRect.anchorMax = new Vector2(0.5f, 0.5f);
        categoryRect.pivot = new Vector2(0.5f, 0.5f);
        //Set rect transform size
        Vector2 categorySize = new Vector2(resolutionWidth, resolutionHeight * 1.6f);
        Vector2 categoryPosition = new Vector2(0, -resolutionHeight / 2);
        categoryRect.sizeDelta = categorySize;
        categoryRect.anchoredPosition = categoryPosition;
        categoryRect.localScale = new Vector3(1, 1, 1);
        //Add background image
        Image categoryBackground = category.AddComponent<Image>();
        categoryBackground.color = new Color32(255, 255, 255, 0);

        //-----Create LevelContainers (12 levels each)
        GameObject container1 = new GameObject("Level" + cat + "00-" + cat + "11");
        GameObject container2 = new GameObject("Level" + cat + "12-" + cat + "23");
        container1.layer = LayerMask.NameToLayer("UI");
        container2.layer = LayerMask.NameToLayer("UI");
        container1.transform.SetParent(category.transform);
        container2.transform.SetParent(category.transform);
        container1.AddComponent<CanvasRenderer>();
        container1.AddComponent<RectTransform>();
        container2.AddComponent<CanvasRenderer>();
        container2.AddComponent<RectTransform>();
        //Set rect transform anchors
        RectTransform container1Rect = container1.GetComponent<RectTransform>();
        RectTransform container2Rect = container2.GetComponent<RectTransform>();
        container1Rect.anchorMin = new Vector2(0, 0.5f);
        container1Rect.anchorMax = new Vector2(0, 0.5f);
        container1Rect.pivot = new Vector2(0.5f, 0.5f);
        container2Rect.anchorMin = new Vector2(0, 0.5f);
        container2Rect.anchorMax = new Vector2(0, 0.5f);
        container2Rect.pivot = new Vector2(0.5f, 0.5f);
        //Set rect transform size
        container1Rect.anchoredPosition = new Vector2(resolutionWidth * 0.5f, 0);
        container1Rect.sizeDelta = new Vector2(resolutionWidth, resolutionHeight);
        container1Rect.localScale = new Vector3(1, 1, 1);
        container2Rect.anchoredPosition = new Vector2(resolutionWidth * 1.5f, 0);
        container2Rect.sizeDelta = new Vector2(resolutionWidth, resolutionHeight);
        container2Rect.localScale = new Vector3(1, 1, 1);


        //-----Create levelbuttons-----
        int column = 0; //This variables are only used for the layout
        int row = 1;
        float xSpacing;
        float ySpacing;
        float buttonHeight;
        float buttonWidth;

        buttonHeight = resolutionHeight / 6.5f;
        if (screenRatio > 1.6f)
        {
            buttonWidth = resolutionWidth / 4.2f;
            ySpacing = buttonWidth * 0.25f;
            xSpacing = buttonWidth * 0.25f;
        }
        else
        {

            buttonWidth = resolutionWidth / 5;
            ySpacing = buttonWidth * 0.3f;
            xSpacing = buttonWidth * 0.3f;
        }

        Vector2 buttonSize = new Vector2(buttonWidth, buttonHeight);
        float xPosition;
        float yPosition;
        if (numberColumns % 2 == 0) //Check if the number of columns is even and format accordingly
        {
            xPosition = (-buttonWidth - xSpacing) * Mathf.Floor(numberColumns / 2) + (buttonWidth + xSpacing) * 0.5f;
        }
        else
        {
            xPosition = (-buttonWidth - xSpacing) * Mathf.Floor(numberColumns / 2);
        }
        if (numberRows % 2 == 0) //Check if the number of rows is even and format accordingly
        {
            yPosition = (buttonHeight + ySpacing) * Mathf.Floor(numberRows / 2) - (buttonHeight + ySpacing) * 0.5f;
        }
        else
        {
            yPosition = (buttonHeight + ySpacing) * Mathf.Floor(numberRows / 2);
        }
        Vector2 buttonPosition = new Vector2(xPosition, yPosition);  //Get the button position of the initial button
        for (int i = 0; i < 24; i++)
        {
            column++;
            if (column > numberColumns)
            { //Start a new row
                column = 1;
                row++;
                float tempYPosition = buttonPosition.y - buttonHeight - ySpacing;
                if (row > numberRows)
                {
                    row = 1;
                    tempYPosition = yPosition;
                }
                buttonPosition = new Vector2(xPosition, tempYPosition);

            }


            CreateLevelButton(i, cat, container1.transform, buttonPosition, buttonSize);
            buttonPosition += new Vector2(buttonWidth + xSpacing, 0); // Add button width and xSpacing to the current position
        }

        //-----Create arrows-----------
        //CreateArrow(true, container1.transform);
        //CreateArrow(false, container2.transform);

        return category;
    }

    //Create a levelbutton
    //This function takes the level number and the parent to which the categories have to be attached, as argument
    void CreateLevelButton(int buttonNumber, int category, Transform parent, Vector2 buttonPosition, Vector2 buttonSize)
    {
        string levelNumber;
        if (buttonNumber < 10)
        {
            levelNumber = category + "0" + buttonNumber;
        }
        else
        {
            levelNumber = category + "" + buttonNumber;
        }
        //Create button panel
        //GameObject levelButton = new GameObject("Level" + levelNumber + "ButtonPanel");
        GameObject levelButton = Instantiate(levelButtonPrefab);
        levelButton.name = "Level" + levelNumber + "ButtonPanel";
        levelButton.transform.SetParent(parent);
        levelButton.layer = LayerMask.NameToLayer("UI");
        RectTransform levelButtonRect = levelButton.GetComponent<RectTransform>();
        //Set button panel rect
        levelButtonRect.anchorMin = new Vector2(0.5f, 0.5f);
        levelButtonRect.anchorMax = new Vector2(0.5f, 0.5f);
        levelButtonRect.pivot = new Vector2(0.5f, 0.5f);
        //Set rect transform size and position
        float sizeMultiplier = (1f / 1920) * Screen.height;
        levelButtonRect.localScale = new Vector3(levelButtonRect.localScale.x * sizeMultiplier, levelButtonRect.localScale.y * sizeMultiplier, 1);
        levelButtonRect.anchoredPosition = buttonPosition;

        PrepareLevelButton prepareLevelButton = levelButton.GetComponent<PrepareLevelButton>();
        prepareLevelButton.SetLevelNumber(category, buttonNumber);
    }

    //Funciton to create level unlocked panel
    void CreateLevelUnlocked(Transform parent)
    {
        levelUnlockedPanel = Instantiate(categoryUnlockedPrefab);
        levelUnlockedPanel.transform.SetParent(parent);
        float sizeMultiplier = (1f / 1920) * Screen.height;
        RectTransform categoryUnlockedRect = levelUnlockedPanel.GetComponent<RectTransform>();
        categoryUnlockedRect.localScale = new Vector3(categoryUnlockedRect.localScale.x * sizeMultiplier, categoryUnlockedRect.localScale.y * sizeMultiplier, 1);
        levelUnlockedPanel.SetActive(false);
    }

    //Function to create category choice
    //This function return the game object for reference by the menu script
    GameObject CreateCategoryChoice(GameObject levelChoice)
    {
        MenuScript menuScript = levelChoice.AddComponent<MenuScript>();
        GameObject categoryChoice = new GameObject("CategoryChoice");
        categoryChoice.transform.SetParent(levelChoice.transform);
        categoryChoice.layer = LayerMask.NameToLayer("UI");
        categoryChoice.AddComponent<CanvasRenderer>();
        RectTransform categoryChoiceRect = categoryChoice.AddComponent<RectTransform>();
        //Set category choice rect
        categoryChoiceRect.anchorMin = new Vector2(0, 0);
        categoryChoiceRect.anchorMax = new Vector2(1, 1);
        categoryChoiceRect.pivot = new Vector2(0.5f, 0.5f);
        //Category choice size
        categoryChoiceRect.offsetMax = new Vector2(0, 0);
        categoryChoiceRect.offsetMin = new Vector2(0, 0);
        categoryChoiceRect.localScale = new Vector3(1, 1, 1);

        CreateStarsInPossesionObject(categoryChoice);

        //Create category buttons
        float buttonWidth;
        float positionX = 0;

        if (screenRatio > 1.5f) { buttonWidth = resolutionWidth * 0.8f; } else { buttonWidth = resolutionWidth * 0.8f; }
        float buttonHeight = buttonWidth / 2.25f;
        float buttonSpacing = (resolutionHeight / 5) / 12;
        float positionY = buttonHeight * 1.5f + buttonSpacing * 1.5f;

        for (int i = 1; i < 5; i++)
        {
            GameObject categoryButton = Instantiate(categoryButtonPrefab);
            categoryButton.transform.SetParent(categoryChoice.transform);
            RectTransform categoryButtonRect = categoryButton.GetComponent<RectTransform>();
            //Set dot rect size

            categoryButtonRect.anchoredPosition = new Vector2(positionX, positionY);
            float sizeMultiplier = (1f / 1920) * Screen.height;
            categoryButtonRect.localScale = new Vector3(categoryButtonRect.localScale.x * sizeMultiplier, categoryButtonRect.localScale.y * sizeMultiplier, 1);

            //----- Set category Information -----
            SetCategoryInfo setCategoryInfo = categoryButton.GetComponent<SetCategoryInfo>();
            setCategoryInfo.SetCategoryNumber(i);
            setCategoryInfo.SetMenuScript(menuScript);


            //----- Add level locked images ----
            GameObject lockedLevelObject = categoryButton.transform.Find("LockedCategoryImage").gameObject;
            TextMeshProUGUI starsNeededText = lockedLevelObject.transform.Find("NumberOfStarsNeeded").GetComponent<TextMeshProUGUI>();
            if (i > 1)
            { 
                //Add script
                int starsNeeded = 0;
                switch (i)
                {
                    case 2: starsNeeded = 40; break;
                    case 3: starsNeeded = 90; break;
                    case 4: starsNeeded = 140; break;
                }
                starsNeededText.text = starsNeeded.ToString();
                UnlockLevel lockedLevelScript = lockedLevelObject.AddComponent<UnlockLevel>();
                lockedLevelScript.neededStars = starsNeeded;
                lockedLevelScript.levelUnlocked = levelUnlockedPanel;
                lockedLevelScript.levelUnlockedTitle = "LEVEL PACK " + i;
                lockedLevelScript.levelUnlockedText = "Congratulations!\nYou just unlocked new levels!";
                lockedLevelScript.levelUnlockedImage = categorySprite[i - 1];
                lockedLevelScript.levelPackNumber = i.ToString();

                categoryButton.GetComponent<Button>().enabled = false;
            }
            else
            {
                lockedLevelObject.SetActive(false);
            }
            positionY -= buttonHeight + buttonSpacing;
        }

        return categoryChoice;
    }

    private void CreateStarsInPossesionObject(GameObject parent)
    {
        

        //Create StarsInPossesionGraphic
        GameObject starsInPossesion = Instantiate(numberOfStarsPrefab);
        starsInPossesion.transform.SetParent(parent.transform);
        RectTransform starsInPossesionRect = starsInPossesion.GetComponent<RectTransform>();
        starsInPossesionRect.anchoredPosition = new Vector2(-100*sizeMultiplier, -100*sizeMultiplier);
        starsInPossesionRect.localScale = new Vector2(starsInPossesionRect.localScale.x * sizeMultiplier, starsInPossesionRect.localScale.y * sizeMultiplier);
    }
}


