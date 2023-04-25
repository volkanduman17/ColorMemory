using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetColorController : MonoBehaviour
{

    private PlayerColorController playerColorController;
    private SquareController squareController;

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