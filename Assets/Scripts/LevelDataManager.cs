using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelDataManager : MonoBehaviour
{
    private static string LevelKey = "LevelDataKey";
    private static int DefaultLevelValue = 1;

    public static int Level
    {
        get => PlayerPrefs.GetInt(LevelKey, DefaultLevelValue);
        set => PlayerPrefs.SetInt(LevelKey, value);
    }
}
