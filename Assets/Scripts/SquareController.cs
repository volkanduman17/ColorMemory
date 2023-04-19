using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SquareController : MonoBehaviour
{
    private MeshRenderer meshRenderer;
    public ColorData colorData;

    private void Start()
    {
        //meshRenderer = GetComponent<MeshRenderer>();
    }

    public void Initialize(ColorData data)
    {
        colorData = data;
        meshRenderer = GetComponent<MeshRenderer>();
        meshRenderer.material = data.mat;
    }
}
