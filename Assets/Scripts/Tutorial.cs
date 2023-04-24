using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tutorial : MonoBehaviour
{
    public GameObject Colors;
    public GameObject TutorialUI;
    public GameObject Hand;
    public GameObject Infinity;
    public GameObject Arrow;
    public Animator TutorialAnimator;
    //public Animator PlayerAnimator;
    PlayerMovement playerMovement;
    PlayerColorController playerColorController;
    public ColorData colorData;

    //public SkinnedMeshRenderer PlayerRenderer;


    private void Start()
    {
        //playerColorController = GetComponent<PlayerColorController>();
        playerMovement = FindObjectOfType<PlayerMovement>();
        playerColorController = FindObjectOfType<PlayerColorController>();


        if (LevelDataManager.Level == 1)
        {
            Debug.Log("level 1");
            TutorialAnimator.enabled = true;
        }
        else
        {
            TutorialAnimator.enabled = false;
            TutorialUI.SetActive(false);
        }
    }


    private void Update()
    {
        
            if (playerMovement.animator.GetBool("isWalking"))
            {
                TutorialAnimator.SetBool("isMovementFinish", true);
                Hand.SetActive(false);
                Infinity.SetActive(false);
                Arrow.SetActive(true);
            }


            if (playerColorController.colordata.ID == "0")
            {
                TutorialAnimator.SetBool("isGetRedFinish", true);
            }


            int trueRed = 0;

            for (int i = 0; i < 9; i++)
            {
                if (LevelManager.Instance.Squares[i].GetComponent<MeshRenderer>().material.color == colorData.mat.color)
                {
                    trueRed++;

                }
            }


            if (trueRed == 9)
            {
                TutorialAnimator.SetBool("isPaintRedFinish", true);
                Colors.SetActive(false);
        }

            if (LevelDataManager.Level == 2)
            {
                TutorialUI.SetActive(false);
                Colors.SetActive(true);
            }
    
    }
       
}