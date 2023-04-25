using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class UILevelController : MonoBehaviour
{
    public TextMeshProUGUI LevelText;

    public static UILevelController Instance;


    private void Awake()
    {
        if (Instance != null)
        {
            Destroy(this);
            return;
        }
        Instance = this;
    }


    public void ShowLevelText()
    {
        LevelText.text = "Level: " + LevelDataManager.Level.ToString();
    }



}