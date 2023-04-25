using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TopLeftImage : MonoBehaviour
{
    public GameObject TopLeftImg;

    void Start()
    {
        
    }

    void Update()
    {
        TopLeftImg.GetComponent<Image>().sprite = LevelManager.Instance.LevelScriptables[LevelDataManager.Level-1].image;
    }
}
