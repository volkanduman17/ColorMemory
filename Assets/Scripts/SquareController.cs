using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SquareController : MonoBehaviour
{
    private MeshRenderer meshRenderer;
    public ColorData colorData;


    public void Initialize(ColorData data)
    {
        colorData = data;
        meshRenderer = GetComponent<MeshRenderer>();
        meshRenderer.material = data.mat;
    }
}
