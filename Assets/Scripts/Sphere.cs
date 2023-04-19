using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sphere : MonoBehaviour
{
    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            Material playerMaterial = collision.gameObject.GetComponent<Renderer>().material;
            GetComponent<MeshRenderer>().material = playerMaterial;
            Debug.Log(playerMaterial.color);
        }
    }
}
