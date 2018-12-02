using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelStatistics : MonoBehaviour {

    public static string STARS_PER_LEVEL_PREFAB = "StarsLevel";
    public static string COMPLETED_LEVELS_PER_CAT = "CompletedLevelsCat";

    int[] starsCategoryOne = new int[24];
    int[] starsCategoryTwo = new int[24];
    int[] starsCategoryThree = new int[24];
    int[] starsCategoryFour = new int[24];

    int[] completedLevelsPerCategory = new int[4];

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
            categoryArray[i] = PlayerPrefs.GetInt(STARS_PER_LEVEL_PREFAB + (categoryNumber + 0));
        }
    }

    public static LevelStatistics GetInstance()
    {
        return instance;
    }
}
