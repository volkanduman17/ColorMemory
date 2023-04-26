using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TopLeftImage : MonoBehaviour
{
    public Image TopLeftImg;

    public void ShowTopLeftImage()
    {
        TopLeftImg.sprite = LevelManager.Instance.LevelScriptables[LevelDataManager.Level-1].image;
    }
}
