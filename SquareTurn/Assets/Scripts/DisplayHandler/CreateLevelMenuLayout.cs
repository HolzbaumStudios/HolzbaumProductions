using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class CreateLevelMenuLayout : MonoBehaviour {


    /// <summary>
    /// This script has to be attached to a UI Canvas Element.
    /// It sets the correct settings for the canvas and creates all child elements for the level menu
    /// This should help with adjusting the menu on different resolutions
    /// </summary>


    public float resolutionWidth;
    public float resolutionHeight;
    public int categroies = 4;


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
    //This function takes the category number and the parent to which the categories have to be attached as argument
    void CreateCategory(int cat, Transform parent)
    {
        //Create Category Object
        GameObject category = new GameObject("Category" + cat);
        category.transform.SetParent(parent);
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

    }


}
