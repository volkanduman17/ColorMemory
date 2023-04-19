using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "colorData")]
public class ColorData : ScriptableObject
{
    public Material mat;
    public string MaterialName;
    public string ID;
}
