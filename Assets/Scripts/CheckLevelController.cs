using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckLevelController : MonoBehaviour
{
    public LevelManager levelManager;

    private void Start()
    {
     //   levelManager = GetComponent<LevelManager>();
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            levelManager.CheckLevelControl();
        }
    }

    
}
