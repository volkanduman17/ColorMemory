using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TopLeftImage : MonoBehaviour
{
    public Image TopLeftImg;

    void Start()
    {
        
    }

    void Update()
    {
        //ShowTopLeftImage();
    }

    public void ShowTopLeftImage()
    {
 
        //if (LevelDataManager.Level == LevelManager.Instance.LevelScriptables.Length)
        //{
        //    TopLeftImg.GetComponent<Image>().sprite = LevelManager.Instance.LevelScriptables[1].image;
        //}
        TopLeftImg.sprite = LevelManager.Instance.LevelScriptables[LevelDataManager.Level-1].image;

    }


}
