using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelStatistics : MonoBehaviour {

    public static string STARS_PER_LEVEL_PREFAB = "StarsLevel";
    public static string COMPLETED_LEVELS_PER_CAT = "CompletedLevelsCat";

    private int[] starsCategoryOne = new int[24];
    private int[] starsCategoryTwo = new int[24];
    private int[] starsCategoryThree = new int[24];
    private int[] starsCategoryFour = new int[24];

    private int[] completedLevelsPerCategory = new int[4];

    private static LevelStatistics instance;

    public void Awake()
    {
        if(instance ==  null)
        {
            instance = this;
        }
        else
        {
            Destroy(this);
        }

        SetCategoryStarsFromPrefab(ref starsCategoryOne, 100);
        SetCategoryStarsFromPrefab(ref starsCategoryTwo, 200);
        SetCategoryStarsFromPrefab(ref starsCategoryThree, 300);
        SetCategoryStarsFromPrefab(ref starsCategoryFour, 400);

        for(int i = 0; i < completedLevelsPerCategory.Length; i++)
        {
            completedLevelsPerCategory[i] = PlayerPrefs.GetInt(COMPLETED_LEVELS_PER_CAT + i);
        }
    }

    public void SetCategoryStarsFromPrefab(ref int[] categoryArray, int categoryNumber)
    {
        for (int i = 0; i < categoryArray.Length; i++)
        {
            string prefabName = STARS_PER_LEVEL_PREFAB + (categoryNumber + i);
            categoryArray[i] = PlayerPrefs.GetInt(prefabName);
        }
    }

    public static LevelStatistics GetInstance()
    {
        return instance;
    }

    public void UpdateLocalAndPrefabStarValue(int category, int level, int numberOfStars)
    {
        switch (category)
        {
            case 1:
                starsCategoryOne[level] = numberOfStars;
                break;
            case 2:
                starsCategoryTwo[level] = numberOfStars;
                break;
            case 3:
                starsCategoryThree[level] = numberOfStars;
                break;
            case 4:
                starsCategoryFour[level] = numberOfStars;
                break;
        }
        string prefabName = STARS_PER_LEVEL_PREFAB + (category*100 + level);
        PlayerPrefs.SetInt(prefabName, numberOfStars);
    }

    public void AddCompletedLevel(int category)
    {
        completedLevelsPerCategory[category - 1]++;
        PlayerPrefs.SetInt(COMPLETED_LEVELS_PER_CAT + (category-1), completedLevelsPerCategory[category - 1]);
    }

    public int GetNumberOfStars(int category, int level)
    {
        int numberOfStars = 0;
        switch(category)
        {
            case 1:
                numberOfStars = starsCategoryOne[level];
                break;
            case 2:
                numberOfStars = starsCategoryTwo[level];
                break;
            case 3:
                numberOfStars = starsCategoryThree[level];
                break;
            case 4:
                numberOfStars = starsCategoryFour[level];
                break;
        }
        return numberOfStars;
    }

    public int GetNumberOfCompletedLevels(int category)
    {
        return completedLevelsPerCategory[category - 1];
    }

    public int GetTotalCompletedLevels()
    {
        int totalNumber = 0;
        foreach(int completedLevels in completedLevelsPerCategory)
        {
            totalNumber += completedLevels;
        }
        return totalNumber;
    }
}
