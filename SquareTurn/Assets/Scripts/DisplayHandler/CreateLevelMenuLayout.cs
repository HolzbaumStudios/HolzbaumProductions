﻿using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System;
using UnityEditor.Animations;

public class CreateLevelMenuLayout : MonoBehaviour {


    /// <summary>
    /// This script has to be attached to a UI Canvas Element.
    /// It sets the correct settings for the canvas and creates all child elements for the level menu
    /// This should help with adjusting the menu on different resolutions
    /// </summary>


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
    public Font textFont;
    public GameObject scrollbarPrefab; //Scrollbar prefab
    public AnimatorController animationController;

    //Private reference variables
    private GameObject scrollbar; //For having reference across the script
    private GameObject levelUnlockedPanel; //Reference to levelUnlockedPanel across the script
    private float screenRatio;
 

	public void CreateLayout()
    {
        if(resolutionHeight > resolutionWidth)
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
        scrollbar = Instantiate(scrollbarPrefab);
        scrollbar.transform.SetParent(levelChoice.transform);
        scrollbar.name = "Scrollbar";

        //-----Create categories-----
        for(int cat = 1; cat <= categroies; cat++)
        {
            CreateCategory(cat, levelChoice.transform);
        }

        //------Create level unlocked panel-----
        CreateLevelUnlocked(this.gameObject.transform);

        //-----Create Category Choice Panel-----
        GameObject categoryChoice = CreateCategoryChoice(levelChoice);

    }

    //Create a category
    //This function takes the category number and the parent to which the categories have to be attached, as argument
    void CreateCategory(int cat, Transform parent)
    {
        //Create Category Object
        GameObject category = new GameObject("Category" + cat);
        category.transform.SetParent(parent);
        category.layer = LayerMask.NameToLayer("UI");
        category.AddComponent<CanvasRenderer>();
        category.AddComponent<RectTransform>();
        //Set rect transform size
        RectTransform categoryRect = category.GetComponent<RectTransform>();
        categoryRect.offsetMin = new Vector2(0, 0);
        categoryRect.offsetMax = new Vector2(resolutionWidth, 0);
        categoryRect.localScale = new Vector3(1, 1, 1);
        //Set rect transform anchors
        categoryRect.anchorMin = new Vector2(0, 0);
        categoryRect.anchorMax = new Vector2(1, 1);
        categoryRect.pivot = new Vector2(0.5f, 0.5f);

        //Create LevelContainers (12 levels each)
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
        float xSpacing = resolutionWidth / 15;
        float ySpacing = resolutionHeight / 22;
        float buttonHeight = resolutionHeight / 6.5f;
        float buttonWidth = resolutionWidth / 5.0f;
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
        arrowPanelRect.anchorMin = new Vector2(0.5f, 0);
        arrowPanelRect.anchorMax = new Vector2(0.5f, 0);
        arrowPanelRect.pivot = new Vector2(0.5f, 0.5f);
        //Set Panelsize
        float arrowPanelHeight = resolutionHeight / 9.5f;
        arrowPanelRect.sizeDelta = new Vector2(resolutionWidth, arrowPanelHeight);
        arrowPanelRect.anchoredPosition = new Vector2(0, arrowPanelHeight / 2);
        arrowPanelRect.localScale = new Vector3(1, 1, 1);
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
        float arrowSize = arrowPanelHeight * 0.8f;
        float arrowXOffset = resolutionWidth / 4;
        arrowRect.sizeDelta = new Vector2(arrowSize, arrowSize);
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
        arrowScript.scrollObject = scrollbar;
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
            dotRect.anchorMin = new Vector2(0.5f, 0.5f);
            dotRect.anchorMax = new Vector2(0.5f, 0.5f);
            dotRect.pivot = new Vector2(0.5f, 0.5f);
            //Set dot rect size
            dotRect.localScale = new Vector3(1, 1, 1);
            dotRect.sizeDelta = new Vector2(dotSize, dotSize);
            dotRect.anchoredPosition = new Vector2(dotPositionX, 0);
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
            GameObject levelUnlockedPanelBase = new GameObject("LevelUnlockedPanelBase");
            levelUnlockedPanelBase.transform.SetParent(levelUnlockedPanel.transform);
            levelUnlockedPanelBase.layer = LayerMask.NameToLayer("UI");
            levelUnlockedPanelBase.AddComponent<CanvasRenderer>();
            RectTransform levelUnlockedPanelBaseRect = levelUnlockedPanelBase.AddComponent<RectTransform>();
            //Set rect transform anchors
            levelUnlockedPanelBaseRect.anchorMin = new Vector2(0.5f, 1);
            levelUnlockedPanelBaseRect.anchorMax = new Vector2(0.5f, 1);
            levelUnlockedPanelBaseRect.pivot = new Vector2(0.5f, 0.5f);
            //Set rect size
            Vector2 levelUnlockedSize = new Vector2(resolutionWidth*0.8f, resolutionHeight/7); 
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
            //Add Animator
            Animator levelUnlockedAnimator = levelUnlockedPanelBase.AddComponent<Animator>();
            levelUnlockedAnimator.runtimeAnimatorController = animationController;

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
                levelUnlockedTitleRect.anchoredPosition = new Vector2(-levelUnlockedSize.x*0.35f, -levelUnlockedSize.y * 0.3f);
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
                Vector2 levelUnlockedTextSize = new Vector2(levelUnlockedSize.x * 0.5f, levelUnlockedSize.y * 0.39f);
                levelUnlockedTextRect.localScale = new Vector3(1, 1, 1);
                levelUnlockedTextRect.sizeDelta = levelUnlockedTextSize;
                levelUnlockedTextRect.anchoredPosition = new Vector2(-levelUnlockedSize.x * 0.35f, -levelUnlockedSize.y * 0.6f);
                //Add text component
                Text levelUnlockedTextText = levelUnlockedText.AddComponent<Text>();
                levelUnlockedTextText.font = textFont;
                levelUnlockedTextText.fontStyle = FontStyle.Normal;
                levelUnlockedTextText.resizeTextForBestFit = true;
                levelUnlockedTextText.resizeTextMaxSize = 50;
                levelUnlockedTextText.resizeTextMinSize = 10;
                levelUnlockedTextText.alignment = TextAnchor.UpperLeft;

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
        if (screenRatio > 1.5f) { buttonWidth = resolutionWidth * 0.5f; } else { buttonWidth = resolutionWidth * 0.45f; }         
        float buttonHeight = resolutionHeight / 5;
        float buttonSpacing = (resolutionHeight / 5) / 6;
        float positionY = buttonHeight * 1.5f + buttonSpacing * 1.5f;
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
            categoryButtonRect.anchoredPosition = new Vector2(0, positionY);
            //Add image
            Image categoryButtonImage = categoryButton.AddComponent<Image>();
            categoryButtonImage.sprite = squareImage;
            categoryButtonImage.color = new Color32(72,120,168,255);
            //Add shadow
            Shadow categoryButtonShadow = categoryButton.AddComponent<Shadow>();
            categoryButtonShadow.effectDistance= new Vector2(2, -2);
            //AddButton
            Button categoryButtonScript = categoryButton.AddComponent<Button>();
            categoryButtonScript.onClick.AddListener(() => levelChoice.GetComponent<MenuScript>().ChooseCategory(i));

                //----- Add category button image -----
                GameObject categoryButtonGraphic = new GameObject("Image");
                categoryButtonGraphic.transform.SetParent(categoryButton.transform);
                categoryButtonGraphic.layer = LayerMask.NameToLayer("UI");
                categoryButtonGraphic.AddComponent<CanvasRenderer>();
                RectTransform categoryButtonGraphicRect = categoryButtonGraphic.AddComponent<RectTransform>();
                //Set Image rect
                float imageSize = buttonHeight*0.9f;
                categoryButtonGraphicRect.anchorMin = new Vector2(1, 0.5f);
                categoryButtonGraphicRect.anchorMax = new Vector2(1, 0.5f);
                categoryButtonGraphicRect.pivot = new Vector2(0.5f, 0.5f);
                categoryButtonGraphicRect.localScale = new Vector3(1, 1, 1);
                categoryButtonGraphicRect.sizeDelta = new Vector2(imageSize, imageSize);
                categoryButtonGraphicRect.anchoredPosition = new Vector2(-buttonHeight*0.5f, 0);
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
                Vector2 categoryInformationSize = new Vector2(buttonWidth - imageSize*1.1f, buttonHeight / 4.5f);
                categoryInformationRect.anchorMin = new Vector2(0, 0.5f);
                categoryInformationRect.anchorMax = new Vector2(0, 0.5f);
                categoryInformationRect.pivot = new Vector2(0.5f, 0.5f);
                categoryInformationRect.localScale = new Vector3(1, 1, 1);
                categoryInformationRect.sizeDelta = categoryInformationSize;
                categoryInformationRect.anchoredPosition = new Vector2(categoryInformationSize.x / 2, 0);
                
                    //----- Create star image ------
                    GameObject categoryStar = new GameObject("StarImage");
                    categoryStar.transform.SetParent(categoryInformation.transform);
                    categoryStar.layer = LayerMask.NameToLayer("UI");
                    categoryStar.AddComponent<CanvasRenderer>();
                    RectTransform categoryStarRect = categoryStar.AddComponent<RectTransform>();
                    //Set rect size
                    categoryStarRect.anchorMin = new Vector2(0.5f, 1);
                    categoryStarRect.anchorMax = new Vector2(0.5f, 1);
                    categoryStarRect.pivot = new Vector2(0.5f, 0.5f);
                    categoryStarRect.localScale = new Vector3(1, 1, 1);
                    float categoryStarSize = categoryInformationSize.x *0.35f;
                    categoryStarRect.sizeDelta = new Vector2(categoryStarSize, categoryStarSize);
                    categoryStarRect.anchoredPosition = new Vector2(0, 0);
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
                    //Set star info canvs
                    starInfoRect.anchorMin = new Vector2(0.5f, 0);
                    starInfoRect.anchorMax = new Vector2(0.5f, 0);
                    starInfoRect.pivot = new Vector2(0.5f, 0.5f);
                    starInfoRect.localScale = new Vector3(1, 1, 1);
                    float starInfoSize = categoryInformationSize.x *0.75f;
                    starInfoRect.sizeDelta = new Vector2(starInfoSize, starInfoSize*0.4f);
                    starInfoRect.anchoredPosition = new Vector2(0, 0);
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

                     /////////////////////////////////////////////
                     /////////////                    ////////////
                     /////       Added level lock here ///////////
                     ////////////                     ////////////
                     /////////////////////////////////////////////

            //Set new yPosition
            positionY -= buttonHeight + buttonSpacing;
        }

        return categoryChoice;
    }

}
