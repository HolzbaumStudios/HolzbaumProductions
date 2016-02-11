﻿using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System;

//Makes sure, that the script checkLevelAchievemnts is attached to the object
[RequireComponent(typeof(CheckLevelAchievements))]
public class CreateLevelMenuLayout : MonoBehaviour {


    /// <summary>
    /// This script has to be attached to a UI Canvas Element.
    /// It sets the correct settings for the canvas and creates all child elements for the level menu
    /// This should help with adjusting the menu on different resolutions
    /// </summary>

    public bool portraitMode;
    public float resolutionWidth;
    public float resolutionHeight;
    public float numberColumns = 3; //How many rows with levelButtons should be displayed
    public float numberRows = 4; // How many columns with levelButtons should be displayed
    public int categroies = 4;
    public Sprite squareImage;
    public Sprite starSprite;
    public Sprite arrowSprite;
    public Sprite dotSprite;
    public Sprite[] categorySprite;
    public Sprite lockSprite;
    public Font textFont;
    public GameObject scrollbarPrefab; //Scrollbar prefab
    

    //Private reference variables
    private GameObject scrollbarObject; //For having reference across the script
    private GameObject levelUnlockedPanel; //Reference to levelUnlockedPanel across the script
    private GameObject levelUnlockedPanelBase;
    private GameObject achievementPanel; //Reference to achievementPanel across the script
    private GameObject[] category = new GameObject[4];
    private float screenRatio;
 
    void Awake()
    {
        
        /*if (Screen.height > Screen.width)
        {*/
            resolutionHeight = Screen.height;
            resolutionWidth = Screen.width;
        /* }
         else
         {
             resolutionHeight = Screen.width;
             resolutionWidth = Screen.height;
         }*/

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
        levelChoiceRect.offsetMax = new Vector2(0,0);
        levelChoiceRect.offsetMin = new Vector2(0,0);
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
        for(int cat = 1; cat <= categroies; cat++)
        {
            category[cat -1] = CreateCategory(cat, levelChoice.transform);
        }

        //------Create level unlocked panel-----
        CreateLevelUnlocked(this.gameObject.transform);

        //-----Create achievement panel
        CreateAchievementPanel(this.gameObject.transform);

        //-----Create Category Choice Panel-----
        GameObject categoryChoice = CreateCategoryChoice(levelChoice);

        //-----Add level choice scroll rect and menu script-----
        //Add scrollrect
        ScrollRect scrollRect = levelChoice.AddComponent<ScrollRect>();
        scrollRect.horizontal = true;
        scrollRect.vertical = false;
        scrollRect.movementType = ScrollRect.MovementType.Elastic;
        scrollRect.horizontalScrollbar = scrollbar;
        //Add script
        MenuScript menuScript = levelChoice.AddComponent<MenuScript>();
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
        Vector2 categorySize = new Vector2(resolutionWidth*2, resolutionHeight);
        Vector2 categoryPosition = new Vector2(resolutionWidth / 2, 0);
        categoryRect.sizeDelta = categorySize;
        categoryRect.anchoredPosition = categoryPosition;
        categoryRect.localScale = new Vector3(1, 1, 1);
        //Add background image
        Image categoryBackground = category.AddComponent<Image>();
        categoryBackground.color = new Color32(255, 255, 255, 0);

        //-----Create LevelContainers (12 levels each)
        GameObject container1 = new GameObject("Level" + cat + "00-" + cat +"11");
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
        container1Rect.anchoredPosition = new Vector2(resolutionWidth*0.5f, 0);
        container1Rect.sizeDelta = new Vector2(resolutionWidth, resolutionHeight);
        container1Rect.localScale = new Vector3(1, 1, 1);
        container2Rect.anchoredPosition = new Vector2(resolutionWidth*1.5f, 0);
        container2Rect.sizeDelta = new Vector2(resolutionWidth, resolutionHeight);
        container2Rect.localScale = new Vector3(1, 1, 1);


        //-----Create levelbuttons-----
        int column = 0; //This variables are only used for the layout
        int row = 1;
        float xSpacing;
        float ySpacing;
        float buttonHeight;
        float buttonWidth;
        if(portraitMode) //Portrait
        {
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
                xSpacing = buttonWidth*0.3f;
            }
        }
        else //Landscape
        {
            
            if (screenRatio > 1.6f)
            { 
                buttonHeight = resolutionHeight *0.22f;
                buttonWidth = buttonHeight * 0.9f;
                xSpacing = buttonWidth * 0.3f;
                ySpacing = buttonWidth * 0.2f;
            }
            else
            {
                buttonHeight = resolutionHeight * 0.2f;
                buttonWidth = buttonHeight * 0.85f;
                xSpacing = buttonWidth * 0.3f;
                ySpacing = buttonWidth * 0.3f;
            }
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
        for (int i = 0; i<24; i++)
        {
            column++;
            if (column > numberColumns) { //Start a new row
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

            if(i < 12) //Attach level 0 - 11 to container1 and 12 - 23 to container2
            {
                CreateLevelButton(i, cat, container1.transform, buttonPosition , buttonSize);
            }
            else
            {
                CreateLevelButton(i, cat, container2.transform, buttonPosition, buttonSize);
            }

            buttonPosition += new Vector2(buttonWidth + xSpacing, 0); // Add button width and xSpacing to the current position
        }

        //-----Create arrows-----------
        CreateArrow(true, container1.transform);
        CreateArrow(false, container2.transform);

        return category;
    }

    //Create a levelbutton
    //This function takes the level number and the parent to which the categories have to be attached, as argument
    void CreateLevelButton(int buttonNumber, int category, Transform parent, Vector2 buttonPosition, Vector2 buttonSize)
    {
        string levelNumber;
        if(buttonNumber < 10)
        {
            levelNumber = category + "0" + buttonNumber;
        }
        else
        {
            levelNumber = category + "" + buttonNumber;
        }
        //Create button panel
        GameObject levelButton = new GameObject("Level" + levelNumber + "ButtonPanel");
        levelButton.transform.SetParent(parent);
        levelButton.layer = LayerMask.NameToLayer("UI");
        levelButton.AddComponent<CanvasRenderer>();
        RectTransform levelButtonRect = levelButton.AddComponent<RectTransform>();
        //Set button panel rect
        levelButtonRect.anchorMin = new Vector2(0.5f, 0.5f);
        levelButtonRect.anchorMax = new Vector2(0.5f, 0.5f);
        levelButtonRect.pivot = new Vector2(0.5f, 0.5f);
        //Set rect transform size and position
        levelButtonRect.localScale = new Vector3(1, 1, 1);
        levelButtonRect.sizeDelta = buttonSize;
        levelButtonRect.anchoredPosition = buttonPosition;        
        //Add Image Component
        Image imageScript = levelButton.AddComponent<Image>();
        imageScript.sprite = squareImage;
        imageScript.color = new Color32(72, 120, 168, 255);
        //Add Shadow Component
        Shadow shadowScript = levelButton.AddComponent<Shadow>();
        shadowScript.effectDistance = new Vector2(2, -2);
        shadowScript.useGraphicAlpha = true;
        //Add scripts
        ChooseLevelScript chooseLevelScript = levelButton.AddComponent<ChooseLevelScript>();
        //Add button
        Button buttonScript = levelButton.AddComponent<Button>();
        int level = (category*100) + buttonNumber;
        buttonScript.onClick.AddListener(() =>  chooseLevelScript.LoadLevel(level) ); //The on click function can not be seen on the editor

            //------ Create Lower Button ------------
            GameObject lowerButton = new GameObject("LevelButton");
            lowerButton.transform.SetParent(levelButton.transform);
            lowerButton.layer = LayerMask.NameToLayer("UI");
            lowerButton.AddComponent<CanvasRenderer>();
            RectTransform lowerButtonRect = lowerButton.AddComponent<RectTransform>();
            //Set lower button Rect
            lowerButtonRect.anchorMin = new Vector2(0, 0);
            lowerButtonRect.anchorMax = new Vector2(1, 1);
            lowerButtonRect.pivot = new Vector2(0.5f, 0.5f);
            float offset = buttonSize.x / 14;
            float offsetBottom = buttonSize.y / 3.5f;
            lowerButtonRect.offsetMax = new Vector2(-offset, -offset);
            lowerButtonRect.offsetMin = new Vector2(offset, offsetBottom);
            lowerButtonRect.localScale = new Vector3(1, 1, 1);
            //Add Image Component
            Image lowerButtonImage = lowerButton.AddComponent<Image>();
            lowerButtonImage.sprite = squareImage;
            lowerButtonImage.color = new Color32(58, 112, 165, 255);

                //------ Create Lower Button Text ------
                GameObject buttonText = new GameObject("ButtonText");
                buttonText.transform.SetParent(lowerButton.transform);
                buttonText.layer = LayerMask.NameToLayer("UI");
                buttonText.AddComponent<CanvasRenderer>();
                RectTransform buttonTextRect = buttonText.AddComponent<RectTransform>();
                //Set button text rect
                buttonTextRect.anchorMin = new Vector2(0, 0);
                buttonTextRect.anchorMax = new Vector2(1, 1);
                buttonTextRect.pivot = new Vector2(0.5f, 0.5f);
                float textOffsetSides;
                if (buttonNumber < 9)
                { 
                    textOffsetSides = buttonSize.x / 8.5f;
                }
                else
                {
                    textOffsetSides = buttonSize.x / 20;
                }
                buttonTextRect.offsetMax = new Vector2(-textOffsetSides,0);
                buttonTextRect.offsetMin = new Vector2(textOffsetSides, 0);
                buttonTextRect.localScale = new Vector3(1, 1, 1);
                //Add Text component
                Text textScript = buttonText.AddComponent<Text>();
                textScript.text = category + "-" + (buttonNumber+1);
                textScript.font = textFont;
                textScript.fontStyle = FontStyle.Bold;
                textScript.resizeTextForBestFit = true;
                textScript.resizeTextMaxSize = 140;
                textScript.resizeTextMinSize = 20;
                textScript.alignment = TextAnchor.MiddleCenter;

                //------ Create stars ------
                float starSize = buttonSize.x / 6;
                float starSpacing = buttonSize.x /14;
                float positionX = -starSize - starSpacing;
                float positionY = (float)(buttonSize.y/3.5)/2;
                for (int i=1; i < 4; i++)
                {
                     GameObject star = new GameObject("star");
                    star.transform.SetParent(levelButton.transform);
                    star.layer = LayerMask.NameToLayer("UI");
                    star.AddComponent<CanvasRenderer>();
                     RectTransform starRect = star.AddComponent<RectTransform>();
                    //Set button text rect
                    starRect.anchorMin = new Vector2(0.5f, 0);
                    starRect.anchorMax = new Vector2(0.5f, 0);
                    starRect.pivot = new Vector2(0.5f, 0.5f);
                    //StartSize
                    starRect.localScale = new Vector3(1, 1, 1);
                    starRect.sizeDelta = new Vector2(starSize,starSize);
                    starRect.anchoredPosition = new Vector2(positionX, positionY);
                    //Set new position
                    positionX += starSpacing + starSize;
                    //---- Add image ----
                    Image starImage = star.AddComponent<Image>();
                    starImage.sprite = starSprite;
                    starImage.preserveAspect = true;
                    //----- Add scripts -----
                    StarColorScript starScript = star.AddComponent<StarColorScript>();
                    starScript.starNumber = i;
                    starScript.levelNumber = level;
                }
    }

    //Creates the arrows
    //If right arrow bool is true, create right arrow, else create left arrow
    void CreateArrow(bool rightArrow, Transform parent)
    {
        String panelName;
        if (rightArrow) { panelName = "rightArrowPanel"; } else { panelName = "leftArrowPanel"; }
        GameObject arrowPanel = new GameObject(panelName);
        arrowPanel.transform.SetParent(parent);
        arrowPanel.layer = LayerMask.NameToLayer("UI");
        arrowPanel.AddComponent<CanvasRenderer>();
        RectTransform arrowPanelRect = arrowPanel.AddComponent<RectTransform>();
        //Set arrowpanel rect transform anchors
        arrowPanelRect.pivot = new Vector2(0.5f, 0.5f);
        arrowPanelRect.localScale = new Vector3(1, 1, 1);
        float arrowPanelHeight;
        if (portraitMode) //Portrait
        {
            arrowPanelRect.anchorMin = new Vector2(0.5f, 0);
            arrowPanelRect.anchorMax = new Vector2(0.5f, 0);
            arrowPanelHeight = resolutionHeight / 9.5f;
            arrowPanelRect.sizeDelta = new Vector2(resolutionWidth, arrowPanelHeight);
            arrowPanelRect.anchoredPosition = new Vector2(0, arrowPanelHeight / 2);
        }
        else //Landscape
        {
            arrowPanelRect.anchorMin = new Vector2(0, 0);
            arrowPanelRect.anchorMax = new Vector2(1, 1);
            arrowPanelRect.offsetMin = new Vector2(0, 0);
            arrowPanelRect.offsetMax = new Vector2(0, 0);
            arrowPanelHeight = resolutionWidth / 8.5f;
        }    
        
        //-----Create arrow button-----
        GameObject arrow = new GameObject("arrow");
        arrow.transform.SetParent(arrowPanel.transform);
        arrow.layer = LayerMask.NameToLayer("UI");
        arrow.AddComponent<CanvasRenderer>();
        RectTransform arrowRect = arrow.AddComponent<RectTransform>();
        //Set arrow rect
        int anchorValue;
        if(rightArrow) { anchorValue = 1; } else { anchorValue = 0; }
        arrowRect.anchorMin = new Vector2(anchorValue, 0.5f);
        arrowRect.anchorMax = new Vector2(anchorValue, 0.5f);
        arrowRect.pivot = new Vector2(0.5f, 0.5f);
        //Set arrow size
        float arrowSize;
        float arrowXOffset;
        if (portraitMode) //Portrait
        {
            arrowSize = arrowPanelHeight * 0.8f;
            arrowXOffset = resolutionWidth / 4;
            arrowRect.sizeDelta = new Vector2(arrowSize, arrowSize);
        }
        else //Landscape
        {
            arrowSize = arrowPanelHeight;
            arrowXOffset = resolutionWidth * 0.1f;
            arrowRect.sizeDelta = new Vector2(arrowSize, arrowSize*1.3f);
        }         
        if (rightArrow) { arrowXOffset = arrowXOffset * -1; } else { arrowRect.localRotation = Quaternion.Euler(0, 0, 180); }
        arrowRect.anchoredPosition = new Vector2(arrowXOffset, 0);
        arrowRect.localScale = new Vector3(1, 1, 1);
        //Add image script
        Image arrowImage = arrow.AddComponent<Image>();
        arrowImage.sprite = arrowSprite;
        arrowImage.color = new Color32(249, 143, 74, 255);
        //Add shadow
        Shadow arrowShadow = arrow.AddComponent<Shadow>();
        if (rightArrow) { arrowShadow.effectDistance = new Vector2(1, 0); } else { arrowShadow.effectDistance = new Vector2(-1, 0); }
        //Add arrow script
        ArrowLevelchoice arrowScript = arrow.AddComponent<ArrowLevelchoice>();
        arrowScript.scrollObject = scrollbarObject;
        //Add button
        Button arrowButtonScript = arrow.AddComponent<Button>();
        int value = 0;
        if (rightArrow) { value = 1; }
        arrowButtonScript.onClick.AddListener(() => arrowScript.ScrollLevelMenu(value)); //The on click function can not be seen on the editor
        //Add Dots
        float dotSize = arrowPanelHeight * 0.3f;
        float dotPositionX = -dotSize;
        for (int i = 0; i < 2; i++)
        {
            GameObject dot = new GameObject("Dot");
            dot.transform.SetParent(arrowPanel.transform);
            dot.layer = LayerMask.NameToLayer("UI");
            dot.AddComponent<CanvasRenderer>();
            RectTransform dotRect = dot.AddComponent<RectTransform>();
            //Set dot rect
            if(portraitMode) //Portrait
            {
                dotRect.anchorMin = new Vector2(0.5f, 0.5f);
                dotRect.anchorMax = new Vector2(0.5f, 0.5f);
                dotRect.anchoredPosition = new Vector2(dotPositionX, 0);
            }
            else //Landscape
            {
                dotRect.anchorMin = new Vector2(0.5f, 0);
                dotRect.anchorMax = new Vector2(0.5f, 0);
                dotRect.anchoredPosition = new Vector2(dotPositionX, arrowPanelHeight*0.3f);
            }
            dotRect.pivot = new Vector2(0.5f, 0.5f);
            dotRect.localScale = new Vector3(1, 1, 1);
            dotRect.sizeDelta = new Vector2(dotSize, dotSize);
            //Add image
            Image dotImage = dot.AddComponent<Image>();
            dotImage.sprite = dotSprite;
            if((i == 0 && rightArrow) || (i== 1 && !rightArrow))
            {
                dotImage.color = new Color32(249,143,74,255);
                //Add shadow
                Shadow dotShadow = dot.AddComponent<Shadow>();
                dotShadow.effectDistance = new Vector2(1, 0);
            }

            dotPositionX += dotSize * 2;
        }
    }


    //Funciton to create level unlocked panel
    void CreateLevelUnlocked(Transform parent)
    {
        levelUnlockedPanel = new GameObject("LevelUnlockedPanel");
        levelUnlockedPanel.transform.SetParent(parent);
        levelUnlockedPanel.layer = LayerMask.NameToLayer("UI");
        levelUnlockedPanel.AddComponent<CanvasRenderer>();
        RectTransform levelUnlockedPanelRect = levelUnlockedPanel.AddComponent<RectTransform>();
        //Set rect transform anchors
        levelUnlockedPanelRect.anchorMin = new Vector2(0, 0);
        levelUnlockedPanelRect.anchorMax = new Vector2(1, 1);
        levelUnlockedPanelRect.pivot = new Vector2(0.5f, 0.5f);
        //Set Rect size
        levelUnlockedPanelRect.offsetMin = new Vector2(0, 0);
        levelUnlockedPanelRect.offsetMax = new Vector2(0, 0);
        levelUnlockedPanelRect.localScale = new Vector3(1, 1, 1);
        
            //-----Add level unlocked panel base-----
            levelUnlockedPanelBase = new GameObject("LevelUnlockedPanelBase");
            levelUnlockedPanelBase.SetActive(false);
            levelUnlockedPanelBase.transform.SetParent(levelUnlockedPanel.transform);
            levelUnlockedPanelBase.layer = LayerMask.NameToLayer("UI");
            levelUnlockedPanelBase.AddComponent<CanvasRenderer>();
            RectTransform levelUnlockedPanelBaseRect = levelUnlockedPanelBase.AddComponent<RectTransform>();
            //Set rect transform anchors
            levelUnlockedPanelBaseRect.anchorMin = new Vector2(0.5f, 1);
            levelUnlockedPanelBaseRect.anchorMax = new Vector2(0.5f, 1);
            levelUnlockedPanelBaseRect.pivot = new Vector2(0.5f, 0.5f);
            //Set rect size
            Vector2 levelUnlockedSize;
            if(portraitMode)
            {
                levelUnlockedSize = new Vector2(resolutionWidth*0.8f, resolutionHeight/7); 
            }
            else
            {
                levelUnlockedSize = new Vector2(resolutionHeight*0.8f, resolutionWidth/7); 
            }
            levelUnlockedPanelBaseRect.localScale = new Vector3(1, 1, 1);
            levelUnlockedPanelBaseRect.sizeDelta = levelUnlockedSize;
            levelUnlockedPanelBaseRect.anchoredPosition = new Vector2(0, levelUnlockedSize.y / 2);
            //Add image
            Image levelUnlockedBackground = levelUnlockedPanelBase.AddComponent<Image>();
            levelUnlockedBackground.sprite = squareImage;
            levelUnlockedBackground.color = new Color32(72,120,168,255);
            //Add shadow
            Shadow levelUnlockedShadow = levelUnlockedPanelBase.AddComponent<Shadow>();
            levelUnlockedShadow.effectDistance = new Vector2(2,-2);
            /*/Add Animator
            Animator levelUnlockedAnimator = levelUnlockedPanelBase.AddComponent<Animator>();
            levelUnlockedAnimator.runtimeAnimatorController = (RuntimeAnimatorController)Resources.Load("AchievementMovementPortrait");*/
            //Add animation script
            levelUnlockedPanelBase.AddComponent<AnimationScript>();
            //Add script
            levelUnlockedPanelBase.AddComponent<DisableByTime>();

                //-----Add level unlocked title
                GameObject levelUnlockedTitle = new GameObject("LevelUnlockedTitle");
                levelUnlockedTitle.transform.SetParent(levelUnlockedPanelBase.transform);
                levelUnlockedTitle.layer = LayerMask.NameToLayer("UI");
                levelUnlockedTitle.AddComponent<CanvasRenderer>();
                RectTransform levelUnlockedTitleRect = levelUnlockedTitle.AddComponent<RectTransform>();
                //Set rect transform anchors
                levelUnlockedTitleRect.anchorMin = new Vector2(1, 1);
                levelUnlockedTitleRect.anchorMax = new Vector2(1, 1);
                levelUnlockedTitleRect.pivot = new Vector2(0.5f, 0.5f);
                //Set rect size
                Vector2 levelUnlockedTitleSize = new Vector2(levelUnlockedSize.x*0.5f, levelUnlockedSize.y*0.2f);
                levelUnlockedTitleRect.localScale = new Vector3(1, 1, 1);
                levelUnlockedTitleRect.sizeDelta = levelUnlockedTitleSize;
                levelUnlockedTitleRect.anchoredPosition = new Vector2(-levelUnlockedSize.x*0.4f, -levelUnlockedSize.y * 0.29f);
                //Add text component
                Text levelUnlockedTitleText = levelUnlockedTitle.AddComponent<Text>();
                levelUnlockedTitleText.font = textFont;
                levelUnlockedTitleText.fontStyle = FontStyle.Bold;
                levelUnlockedTitleText.resizeTextForBestFit = true;
                levelUnlockedTitleText.resizeTextMaxSize = 120;
                levelUnlockedTitleText.resizeTextMinSize = 10;
                levelUnlockedTitleText.alignment = TextAnchor.UpperLeft;
                levelUnlockedTitleText.color = new Color32(254,255,186,255);

                //------Add level unlocked Text------
                GameObject levelUnlockedText = new GameObject("LevelUnlockedText");
                levelUnlockedText.transform.SetParent(levelUnlockedPanelBase.transform);
                levelUnlockedText.layer = LayerMask.NameToLayer("UI");
                levelUnlockedText.AddComponent<CanvasRenderer>();
                RectTransform levelUnlockedTextRect = levelUnlockedText.AddComponent<RectTransform>();
                //Set rect transform anchors
                levelUnlockedTextRect.anchorMin = new Vector2(1, 1);
                levelUnlockedTextRect.anchorMax = new Vector2(1, 1);
                levelUnlockedTextRect.pivot = new Vector2(0.5f, 0.5f);
                //Set rect size
                Vector2 levelUnlockedTextSize = new Vector2(levelUnlockedSize.x * 0.62f, levelUnlockedSize.y * 0.48f);
                levelUnlockedTextRect.localScale = new Vector3(1, 1, 1);
                levelUnlockedTextRect.sizeDelta = levelUnlockedTextSize;
                levelUnlockedTextRect.anchoredPosition = new Vector2(-levelUnlockedSize.x * 0.34f, -levelUnlockedSize.y * 0.65f);
                //Add text component
                Text levelUnlockedTextText = levelUnlockedText.AddComponent<Text>();
                levelUnlockedTextText.font = textFont;
                levelUnlockedTextText.fontStyle = FontStyle.Normal;
                levelUnlockedTextText.resizeTextForBestFit = true;
                levelUnlockedTextText.resizeTextMaxSize = 50;
                levelUnlockedTextText.resizeTextMinSize = 5;
                levelUnlockedTextText.alignment = TextAnchor.UpperLeft;

                //-----Add level unlocked image-----
                GameObject levelUnlockedImage = new GameObject("LevelUnlockedImage");
                levelUnlockedImage.transform.SetParent(levelUnlockedPanelBase.transform);
                levelUnlockedImage.layer = LayerMask.NameToLayer("UI");
                levelUnlockedImage.AddComponent<CanvasRenderer>();
                RectTransform levelUnlockedImageRect = levelUnlockedImage.AddComponent<RectTransform>();
                //Set rect transform anchors
                levelUnlockedImageRect.anchorMin = new Vector2(0, 0.5f);
                levelUnlockedImageRect.anchorMax = new Vector2(0, 0.5f);
                levelUnlockedImageRect.pivot = new Vector2(0.5f, 0.5f);
                //Set rect size
                Vector2 levelUnlockedImageSize = new Vector2(levelUnlockedSize.y * 0.7f, levelUnlockedSize.y * 0.7f);
                levelUnlockedImageRect.localScale = new Vector3(1, 1, 1);
                levelUnlockedImageRect.sizeDelta = levelUnlockedImageSize;
                levelUnlockedImageRect.anchoredPosition = new Vector2(levelUnlockedSize.x * 0.2f, 0);
                //Add image
                levelUnlockedImage.AddComponent<Image>();
    }

    //Funciton to create achievement panel
    void CreateAchievementPanel(Transform parent)
    {
        achievementPanel = new GameObject("AchievementPanel");
        achievementPanel.transform.SetParent(parent);
        achievementPanel.layer = LayerMask.NameToLayer("UI");
        achievementPanel.AddComponent<CanvasRenderer>();
        RectTransform achievementPanelRect = achievementPanel.AddComponent<RectTransform>();
        //Set rect transform anchors
        achievementPanelRect.anchorMin = new Vector2(0, 0);
        achievementPanelRect.anchorMax = new Vector2(1, 1);
        achievementPanelRect.pivot = new Vector2(0.5f, 0.5f);
        //Set Rect size
        achievementPanelRect.offsetMin = new Vector2(0, 0);
        achievementPanelRect.offsetMax = new Vector2(0, 0);
        achievementPanelRect.localScale = new Vector3(1, 1, 1);
        
            //-----Add achievement panel base-----
            GameObject achievementPanelBase = new GameObject("AchievementPanelBase");
            achievementPanelBase.SetActive(false);
            achievementPanelBase.transform.SetParent(achievementPanel.transform);
            achievementPanelBase.layer = LayerMask.NameToLayer("UI");
            achievementPanelBase.AddComponent<CanvasRenderer>();
            RectTransform achievementPanelBaseRect = achievementPanelBase.AddComponent<RectTransform>();
            //Set rect transform anchors
            achievementPanelBaseRect.anchorMin = new Vector2(0.5f, 1);
            achievementPanelBaseRect.anchorMax = new Vector2(0.5f, 1);
            achievementPanelBaseRect.pivot = new Vector2(0.5f, 0.5f);
            //Set rect size
            Vector2 achievementPanelSize;
            if(portraitMode) //Portrait
            {
                achievementPanelSize = new Vector2(resolutionWidth * 0.8f, resolutionHeight / 7);
            }
            else //Landscape
            {
                achievementPanelSize = new Vector2(resolutionHeight * 0.8f, resolutionWidth / 7);
            }
            achievementPanelBaseRect.localScale = new Vector3(1, 1, 1);
            achievementPanelBaseRect.sizeDelta = achievementPanelSize;
            achievementPanelBaseRect.anchoredPosition = new Vector2(0, achievementPanelSize.y / 2);
            //Add image
            Image achievementPanelBackground = achievementPanelBase.AddComponent<Image>();
            achievementPanelBackground.sprite = squareImage;
            achievementPanelBackground.color = new Color32(72, 120, 168, 255);
            //Add shadow
            Shadow achievementPanelShadow = achievementPanelBase.AddComponent<Shadow>();
            achievementPanelShadow.effectDistance = new Vector2(2, -2);
            /*/Add Animator
            Animator achievementPanelAnimator = achievementPanelBase.AddComponent<Animator>();
            achievementPanelAnimator.runtimeAnimatorController = (RuntimeAnimatorController)Resources.Load("AchievementMovementPortrait");*/
            //Add animation script
            achievementPanelBase.AddComponent<AnimationScript>();

                //-----Add achievement title
                GameObject achievementTitle = new GameObject("AchievementTitle");
                achievementTitle.transform.SetParent(achievementPanelBase.transform);
                achievementTitle.layer = LayerMask.NameToLayer("UI");
                achievementTitle.AddComponent<CanvasRenderer>();
                RectTransform achievementTitleRect = achievementTitle.AddComponent<RectTransform>();
                //Set rect transform anchors
                achievementTitleRect.anchorMin = new Vector2(1, 1);
                achievementTitleRect.anchorMax = new Vector2(1, 1);
                achievementTitleRect.pivot = new Vector2(0.5f, 0.5f);
                //Set rect size
                Vector2 achievementTitleSize = new Vector2(achievementPanelSize.x * 0.64f, achievementPanelSize.y * 0.2f);
                achievementTitleRect.localScale = new Vector3(1, 1, 1);
                achievementTitleRect.sizeDelta = achievementTitleSize;
                achievementTitleRect.anchoredPosition = new Vector2(-achievementPanelSize.x * 0.38f, -achievementPanelSize.y * 0.29f);
                //Add text component
                Text achievementTitleText = achievementTitle.AddComponent<Text>();
                achievementTitleText.text = "ACHIEVEMENT UNLOCKED";
                achievementTitleText.font = textFont;
                achievementTitleText.fontStyle = FontStyle.Bold;
                achievementTitleText.resizeTextForBestFit = true;
                achievementTitleText.resizeTextMaxSize = 120;
                achievementTitleText.resizeTextMinSize = 4;
                achievementTitleText.alignment = TextAnchor.UpperLeft;
                achievementTitleText.color = new Color32(254, 255, 186, 255);

                //------Add achievement Text------
                GameObject achievementText = new GameObject("AchievementText");
                achievementText.transform.SetParent(achievementPanelBase.transform);
                achievementText.layer = LayerMask.NameToLayer("UI");
                achievementText.AddComponent<CanvasRenderer>();
                RectTransform achievementTextRect = achievementText.AddComponent<RectTransform>();
                //Set rect transform anchors
                achievementTextRect.anchorMin = new Vector2(1, 1);
                achievementTextRect.anchorMax = new Vector2(1, 1);
                achievementTextRect.pivot = new Vector2(0.5f, 0.5f);
                //Set rect size
                Vector2 achievementTextSize = new Vector2(achievementPanelSize.x * 0.64f, achievementPanelSize.y * 0.35f);
                achievementTextRect.localScale = new Vector3(1, 1, 1);
                achievementTextRect.sizeDelta = achievementTextSize;
                achievementTextRect.anchoredPosition = new Vector2(-achievementPanelSize.x * 0.38f, -achievementPanelSize.y * 0.61f);
                //Add text component
                Text achievementTextText = achievementText.AddComponent<Text>();
                achievementTextText.font = textFont;
                achievementTextText.fontStyle = FontStyle.Normal;
                achievementTextText.resizeTextForBestFit = true;
                achievementTextText.resizeTextMaxSize = 50;
                achievementTextText.resizeTextMinSize = 10;
                achievementTextText.alignment = TextAnchor.UpperLeft;

                //-----Add achievement image-----
                GameObject achievementImage = new GameObject("AchievementImage");
                achievementImage.transform.SetParent(achievementPanelBase.transform);
                achievementImage.layer = LayerMask.NameToLayer("UI");
                achievementImage.AddComponent<CanvasRenderer>();
                RectTransform achievementImageRect = achievementImage.AddComponent<RectTransform>();
                //Set rect transform anchors
                achievementImageRect.anchorMin = new Vector2(0, 0.5f);
                achievementImageRect.anchorMax = new Vector2(0, 0.5f);
                achievementImageRect.pivot = new Vector2(0.5f, 0.5f);
                //Set rect size
                Vector2 achievementImageSize = new Vector2(achievementPanelSize.y * 0.75f, achievementPanelSize.y * 0.75f);
                achievementImageRect.localScale = new Vector3(1, 1, 1);
                achievementImageRect.sizeDelta = achievementImageSize;
                achievementImageRect.anchoredPosition = new Vector2(achievementPanelSize.x * 0.15f, 0);
                //Add image
                achievementImage.AddComponent<Image>();

        //Add script
        CheckForAchievements achievementPanelScript = achievementPanel.AddComponent<CheckForAchievements>();
        achievementPanelScript.achievementPanel = achievementPanelBase;
    }

    //Function to create category choice
    //This function return the game object for reference by the menu script
    GameObject CreateCategoryChoice(GameObject levelChoice)
    {
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

        //Create category buttons
        float buttonWidth;
        float buttonHeight;
        float buttonSpacing;
        float positionY = 0;
        float positionX = 0;
        if (portraitMode) //Portrait
        {
            if (screenRatio > 1.5f) { buttonWidth = resolutionWidth * 0.52f; } else { buttonWidth = resolutionWidth * 0.45f; }
            buttonHeight = resolutionHeight / 5;
            buttonSpacing = (resolutionHeight / 5) / 12;
            positionY = buttonHeight * 1.5f + buttonSpacing * 1.5f;
        }
        else //Landscape
        {
            buttonWidth = resolutionWidth * 0.21f;
            if (screenRatio > 1.5f) { buttonHeight = resolutionHeight * 0.45f; } else { buttonHeight = resolutionHeight * 0.38f; }
            buttonSpacing = buttonWidth / 12;
            positionX = -(buttonWidth * 1.5f + buttonSpacing * 1.5f);
        }

        
        for (int i=1; i<5; i++)
        {
            string categoryButtonName = "Category" + i + "Button";
            GameObject categoryButton = new GameObject(categoryButtonName);
            categoryButton.transform.SetParent(categoryChoice.transform);
            categoryButton.layer = LayerMask.NameToLayer("UI");
            categoryButton.AddComponent<CanvasRenderer>();
            RectTransform categoryButtonRect = categoryButton.AddComponent<RectTransform>();
            //Set rect anchor
            categoryButtonRect.anchorMin = new Vector2(0.5f, 0.5f);
            categoryButtonRect.anchorMax = new Vector2(0.5f, 0.5f);
            categoryButtonRect.pivot = new Vector2(0.5f, 0.5f);
            //Set dot rect size
            categoryButtonRect.localScale = new Vector3(1, 1, 1);
            categoryButtonRect.sizeDelta = new Vector2(buttonWidth, buttonHeight);
            categoryButtonRect.anchoredPosition = new Vector2(positionX, positionY);
            //Add image
            Image categoryButtonImage = categoryButton.AddComponent<Image>();
            categoryButtonImage.sprite = squareImage;
            categoryButtonImage.color = new Color32(72,120,168,255);
            //Add shadow
            Shadow categoryButtonShadow = categoryButton.AddComponent<Shadow>();
            categoryButtonShadow.effectDistance= new Vector2(2, -2);
            //AddButton
            Button categoryButtonScript = categoryButton.AddComponent<Button>();
            int tempValue = i;
            categoryButtonScript.onClick.AddListener(() => levelChoice.GetComponent<MenuScript>().ChooseCategory(tempValue));

                //----- Add category button image -----
                GameObject categoryButtonGraphic = new GameObject("Image");
                categoryButtonGraphic.transform.SetParent(categoryButton.transform);
                categoryButtonGraphic.layer = LayerMask.NameToLayer("UI");
                categoryButtonGraphic.AddComponent<CanvasRenderer>();
                RectTransform categoryButtonGraphicRect = categoryButtonGraphic.AddComponent<RectTransform>();
                //Set Image rect
                float imageSize;
                Vector2 anchoredPositionImage;
                if(portraitMode) //Portrait
                {
                    imageSize = buttonHeight*0.9f;
                    anchoredPositionImage = new Vector2(-buttonHeight*0.5f, 0);
                    categoryButtonGraphicRect.anchorMin = new Vector2(1, 0.5f);
                    categoryButtonGraphicRect.anchorMax = new Vector2(1, 0.5f);
                }
                else //Landscape
                {
                    imageSize = buttonWidth*0.9f;
                    anchoredPositionImage = new Vector2(0, -buttonWidth * 0.5f);
                    categoryButtonGraphicRect.anchorMin = new Vector2(0.5f, 1);
                    categoryButtonGraphicRect.anchorMax = new Vector2(0.5f, 1);
                }
                categoryButtonGraphicRect.pivot = new Vector2(0.5f, 0.5f);
                categoryButtonGraphicRect.localScale = new Vector3(1, 1, 1);
                categoryButtonGraphicRect.sizeDelta = new Vector2(imageSize, imageSize);
                categoryButtonGraphicRect.anchoredPosition = anchoredPositionImage;
                //Add image
                Image categoryButtonGraphicImage = categoryButtonGraphic.AddComponent<Image>();
                categoryButtonGraphicImage.sprite = categorySprite[i-1];

                //----- Add category Information -----
                GameObject categoryInformation = new GameObject("CategoryInformation");
                categoryInformation.transform.SetParent(categoryButton.transform);
                categoryInformation.layer = LayerMask.NameToLayer("UI");
                categoryInformation.AddComponent<CanvasRenderer>();
                RectTransform categoryInformationRect = categoryInformation.AddComponent<RectTransform>();
                //Set category information rect
                Vector2 categoryInformationSize;
                if (portraitMode) //Portrait
                {
                    categoryInformationSize = new Vector2(buttonWidth - imageSize*1.1f, buttonHeight / 4.5f);
                    categoryInformationRect.anchorMin = new Vector2(0, 0.5f);
                    categoryInformationRect.anchorMax = new Vector2(0, 0.5f);
                    categoryInformationRect.anchoredPosition = new Vector2(categoryInformationSize.x / 2, 0);
                }
                else //Landscape
                {
                    categoryInformationSize = new Vector2(buttonWidth*0.6f, buttonHeight-imageSize*1.05f);
                    categoryInformationRect.anchorMin = new Vector2(0, 0);
                    categoryInformationRect.anchorMax = new Vector2(0, 0);
                    categoryInformationRect.anchoredPosition = new Vector2(categoryInformationSize.x * 0.57f, categoryInformationSize.y *0.5f);
                }
                categoryInformationRect.pivot = new Vector2(0.5f, 0.5f);
                categoryInformationRect.localScale = new Vector3(1, 1, 1);
                categoryInformationRect.sizeDelta = categoryInformationSize;
                
                    //----- Create star image ------
                    GameObject categoryStar = new GameObject("StarImage");
                    categoryStar.transform.SetParent(categoryInformation.transform);
                    categoryStar.layer = LayerMask.NameToLayer("UI");
                    categoryStar.AddComponent<CanvasRenderer>();
                    RectTransform categoryStarRect = categoryStar.AddComponent<RectTransform>();
                    //Set rect size
                    float categoryStarSize;
                    Vector2 categoryStarPosition;
                    if(portraitMode) //Portrait
                    {
                        categoryStarRect.anchorMin = new Vector2(0.5f, 1);
                        categoryStarRect.anchorMax = new Vector2(0.5f, 1);
                        categoryStarSize = categoryInformationSize.x *0.35f;
                        categoryStarPosition = new Vector2(0,0);
                    }
                    else //Landscape
                    {
                        categoryStarRect.anchorMin = new Vector2(0, 0.5f);
                        categoryStarRect.anchorMax = new Vector2(0, 0.5f);
                        categoryStarSize = categoryInformationSize.y *0.6f;
                        categoryStarPosition = new Vector2(categoryStarSize*0.65f,0);
                    }
                    categoryStarRect.pivot = new Vector2(0.5f, 0.5f);
                    categoryStarRect.localScale = new Vector3(1, 1, 1);
                    categoryStarRect.sizeDelta = new Vector2(categoryStarSize, categoryStarSize);
                    categoryStarRect.anchoredPosition = categoryStarPosition;
                    //Add image
                    Image categoryStarImage = categoryStar.AddComponent<Image>();
                    categoryStarImage.sprite = starSprite;
                    categoryStarImage.color = new Color32(254,255,186,255);
                    //Add shadow
                    Shadow categoryStarShadow = categoryStar.AddComponent<Shadow>();
                    categoryStarShadow.effectDistance = new Vector2(1, -1);

                    //----- Create star info ------
                    GameObject starInfo = new GameObject("starInfo");
                    starInfo.transform.SetParent(categoryInformation.transform);
                    starInfo.layer = LayerMask.NameToLayer("UI");
                    starInfo.AddComponent<CanvasRenderer>();
                    RectTransform starInfoRect = starInfo.AddComponent<RectTransform>();
                    //Set star info rect
                    float starInfoSize;
                    Vector2 starInfoPosition;
                    if(portraitMode) //Portrait
                    {
                        starInfoRect.anchorMin = new Vector2(0.5f, 0);
                        starInfoRect.anchorMax = new Vector2(0.5f, 0);
                        starInfoSize = categoryInformationSize.x *0.75f;
                        starInfoRect.sizeDelta = new Vector2(starInfoSize, starInfoSize*0.4f);
                        starInfoPosition = new Vector2(0, 0);
            }
                    else //Landscape
                    {
                        starInfoRect.anchorMin = new Vector2(1, 0.5f);
                        starInfoRect.anchorMax = new Vector2(1, 0.5f);
                        starInfoSize = categoryInformationSize.y *0.75f;
                        starInfoRect.sizeDelta = new Vector2(starInfoSize*2.5f, starInfoSize * 0.9f);
                        starInfoPosition = new Vector2(-starInfoSize* 0.6f, -starInfoSize*0.05f);
                    }
                    starInfoRect.pivot = new Vector2(0.5f, 0.5f);
                    starInfoRect.localScale = new Vector3(1, 1, 1); 
                    starInfoRect.anchoredPosition = starInfoPosition;
                    //Add text
                    Text starInfoText = starInfo.AddComponent<Text>();
                    starInfoText.text = "20 / 72";
                    starInfoText.font = textFont;
                    starInfoText.fontStyle = FontStyle.Bold;
                    starInfoText.resizeTextForBestFit = true;
                    starInfoText.resizeTextMaxSize = 80;
                    starInfoText.resizeTextMinSize = 10;
                    starInfoText.alignment = TextAnchor.MiddleCenter;
                    //Add script
                    SetCategoryInfo setCategoryInfo = starInfo.AddComponent<SetCategoryInfo>();
                    setCategoryInfo.categoryNumber = i;
                    setCategoryInfo.maxStars = "72";


            //----- Add level locked images ----
            if(i > 1)
            {
                string lockedLevelName = "ShowCategory" + i;
                GameObject lockedLevel = new GameObject(lockedLevelName);
                lockedLevel.transform.SetParent(categoryChoice.transform);
                lockedLevel.layer = LayerMask.NameToLayer("UI");
                lockedLevel.AddComponent<CanvasRenderer>();
                RectTransform lockedLevelRect = lockedLevel.AddComponent<RectTransform>();
                //Set rect anchor
                lockedLevelRect.anchorMin = new Vector2(0.5f, 0.5f);
                lockedLevelRect.anchorMax = new Vector2(0.5f, 0.5f);
                lockedLevelRect.pivot = new Vector2(0.5f, 0.5f);
                //Set dot rect size
                lockedLevelRect.localScale = new Vector3(1, 1, 1);
                lockedLevelRect.sizeDelta = new Vector2(buttonWidth, buttonHeight);
                lockedLevelRect.anchoredPosition = new Vector2(positionX, positionY);
                //Add image
                Image lockedLevelBackground = lockedLevel.AddComponent<Image>();
                lockedLevelBackground.sprite = squareImage;
                lockedLevelBackground.color = new Color32(141, 141, 141, 255);
                //Add script
                int starsNeeded = 0;
                switch(i)
                {
                    case 2: starsNeeded = 40; break;
                    case 3: starsNeeded = 90; break;
                    case 4: starsNeeded = 140; break;
                }
                UnlockLevel lockedLevelScript = lockedLevel.AddComponent<UnlockLevel>();
                lockedLevelScript.neededStars = starsNeeded;
                lockedLevelScript.levelUnlocked = levelUnlockedPanelBase;
                lockedLevelScript.levelUnlockedTitle = "LEVELE PACK " + i;
                lockedLevelScript.levelUnlockedText = "Congratulations!\nYou just unlocked new levels!";
                lockedLevelScript.levelUnlockedImage = categorySprite[i-1];
                lockedLevelScript.levelPackNumber = i.ToString();

                    //----- Add locked Title------
                    GameObject lockedLevelTitle = new GameObject("LockedTitle");
                    lockedLevelTitle.transform.SetParent(lockedLevel.transform);
                    lockedLevelTitle.layer = LayerMask.NameToLayer("UI");
                    lockedLevelTitle.AddComponent<CanvasRenderer>();
                    RectTransform lockedLevelTitleRect = lockedLevelTitle.AddComponent<RectTransform>();
                    //Set rect
                    lockedLevelTitleRect.anchorMin = new Vector2(0.5f, 0.5f);
                    lockedLevelTitleRect.anchorMax = new Vector2(0.5f, 0.5f);
                    lockedLevelTitleRect.pivot = new Vector2(0.5f, 0.5f);
                    Vector2 lockedTitleSize = new Vector2(buttonWidth*0.8f, buttonHeight*0.15f);
                    lockedLevelTitleRect.localScale = new Vector3(1, 1, 1);
                    lockedLevelTitleRect.sizeDelta = lockedTitleSize;
                    lockedLevelTitleRect.anchoredPosition = new Vector2(0, buttonHeight*0.35f);
                    //Add Text
                    Text lockedTitleText = lockedLevelTitle.AddComponent<Text>();
                    lockedTitleText.text = "LEVELS LOCKED";
                    lockedTitleText.font = textFont;
                    lockedTitleText.fontStyle = FontStyle.Bold;
                    lockedTitleText.resizeTextForBestFit = true;
                    lockedTitleText.resizeTextMaxSize = 30;
                    lockedTitleText.resizeTextMinSize = 5;
                    lockedTitleText.alignment = TextAnchor.MiddleCenter;
                    lockedTitleText.color = new Color32(254,255,186,255);
                    
                    //----- Add locked Image------
                    GameObject lockedLevelImage = new GameObject("LockedImage");
                    lockedLevelImage.transform.SetParent(lockedLevel.transform);
                    lockedLevelImage.layer = LayerMask.NameToLayer("UI");
                    lockedLevelImage.AddComponent<CanvasRenderer>();
                    RectTransform lockedLevelImageRect = lockedLevelImage.AddComponent<RectTransform>();
                    //Set rect anchor
                    Vector2 lockedImageSize;
                    Vector2 lockedImagePosition;
                    if(portraitMode) //Portrait
                    {
                        lockedImageSize = new Vector2(buttonHeight*0.7f, buttonHeight*0.7f);
                        lockedImagePosition = new Vector2(-buttonWidth * 0.28f, -buttonHeight * 0.07f);
                }
                    else //Landscape
                    {
                        lockedImageSize = new Vector2(buttonHeight*0.4f, buttonHeight*0.38f);
                        lockedImagePosition = new Vector2(0, -buttonHeight * 0.3f);
                    }
                    lockedLevelImageRect.anchorMin = new Vector2(0.5f, 0.5f);
                    lockedLevelImageRect.anchorMax = new Vector2(0.5f, 0.5f);
                    lockedLevelImageRect.pivot = new Vector2(0.5f, 0.5f);
                    lockedLevelImageRect.localScale = new Vector3(1, 1, 1);
                    lockedLevelImageRect.sizeDelta = lockedImageSize;
                    lockedLevelImageRect.anchoredPosition = lockedImagePosition;
                    //Add Image
                    Image lockedImageSprite = lockedLevelImage.AddComponent<Image>();
                    lockedImageSprite.sprite = lockSprite;
                    lockedImageSprite.preserveAspect = true;
                    //Add shadow
                    Shadow lockedImageShadow = lockedLevelImage.AddComponent<Shadow>();
                    lockedImageShadow.effectDistance = new Vector2(1, -1);

                    //----- Add locked Text------
                    GameObject lockedLevelText = new GameObject("LockedText");
                    lockedLevelText.transform.SetParent(lockedLevel.transform);
                    lockedLevelText.layer = LayerMask.NameToLayer("UI");
                    lockedLevelText.AddComponent<CanvasRenderer>();
                    RectTransform lockedLevelTextRect = lockedLevelText.AddComponent<RectTransform>();
                    //Set rect anchor
                    Vector2 lockedTextSize;
                    Vector2 lockedTextPosition;
                    if(portraitMode) //Portrait
                    {
                        lockedTextSize = new Vector2(buttonWidth * 0.48f, buttonHeight * 0.65f);
                        lockedTextPosition = new Vector2(buttonWidth * 0.15f, -buttonHeight * 0.07f);
                }
                    else //Landscape
                    {
                        lockedTextSize = new Vector2(buttonWidth * 0.8f, buttonHeight * 0.31f);
                        lockedTextPosition = new Vector2(0, buttonHeight * 0.07f);
                    }
                    lockedLevelTextRect.anchorMin = new Vector2(0.5f, 0.5f);
                    lockedLevelTextRect.anchorMax = new Vector2(0.5f, 0.5f);
                    lockedLevelTextRect.pivot = new Vector2(0.5f, 0.5f);   
                    lockedLevelTextRect.localScale = new Vector3(1, 1, 1);
                    lockedLevelTextRect.sizeDelta = lockedTextSize;
                    lockedLevelTextRect.anchoredPosition = lockedTextPosition;
                    //Add Text
                    string lockedText = "";
                    switch(i) //Change text based on category
                    {
                        case 2: lockedText = "Available after collecting a total of 40 stars";  break;
                        case 3: lockedText = "Available after collecting a total of 90 stars"; break;
                        case 4: lockedText = "Available after collecting a total of 140 stars";  break;
                    }
                    Text lockedTextText = lockedLevelText.AddComponent<Text>();
                    lockedTextText.text = lockedText;
                    lockedTextText.font = textFont;
                    lockedTextText.resizeTextForBestFit = true;
                    lockedTextText.resizeTextMaxSize = 35;
                    lockedTextText.resizeTextMinSize = 5;
                    if (portraitMode)
                    {
                        lockedTextText.alignment = TextAnchor.MiddleLeft;
                    }
                    else
                    {
                        lockedTextText.alignment = TextAnchor.MiddleCenter;
                    }      
            }

            //Set new yPosition
            if (portraitMode)
            {
                positionY -= buttonHeight + buttonSpacing;
            }
            else // Set new xPosition
            {
                positionX += buttonWidth + buttonSpacing;
            }  
        }

        return categoryChoice;
    }

    
}


