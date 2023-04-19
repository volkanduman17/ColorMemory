using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerColorController : MonoBehaviour
{
    public ColorData colordata;
    public SkinnedMeshRenderer renderer;

    public void InýtializeColorData(ColorData data)
    {
        colordata = data;
        renderer.material = data.mat;
    }
}
