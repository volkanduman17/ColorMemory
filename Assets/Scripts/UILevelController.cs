using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class UILevelController : MonoBehaviour
{
    public TextMeshProUGUI LevelText;




    void Start()
    {
        LevelText.text = "Level: " + LevelDataManager.Level.ToString();

    }

}