using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetColorController : MonoBehaviour
{

  //  public MeshRenderer squareRenderer;
  //  public SkinnedMeshRenderer PlayerRenderer;
    private PlayerColorController playerColorController;
    private SquareController squareController;
    //public GameObject player;

    private void Start()
    {
        squareController = GetComponent<SquareController>();
        playerColorController = GetComponent<PlayerColorController>();
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("ColorContainer"))
        {
            ColorData data = other.gameObject.GetComponent<ColorContainer>().colorData;
            playerColorController.InýtializeColorData(data);

        }

        if (other.gameObject.CompareTag("Square"))
        {
            ColorData data = playerColorController.colordata;
            other.gameObject.GetComponent<SquareController>().Initialize(data);
            // kare her boyandýðýnda             
        }
    }
}