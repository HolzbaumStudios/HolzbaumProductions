﻿using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System;

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
    public Font textFont;


	public void CreateLayout()
    {
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
 

        //-----Create categories-----
        for(int cat = 1; cat <= categroies; cat++)
        {
            CreateCategory(cat, levelChoice.transform);
        }

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

}
