using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerColorController : MonoBehaviour
{
    public ColorData colordata;
    public SkinnedMeshRenderer skinnedrenderer;

    public void InýtializeColorData(ColorData data)
    {
        colordata = data;
        skinnedrenderer.material = data.mat;
    }
}
