using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "newLevel")]

public class Levels : ScriptableObject
{
    public string LevelName;
    public ColorData[] colorDatas = new ColorData[9];
    public Sprite image;   
}
