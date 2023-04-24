using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelManager : MonoBehaviour
{
    public static LevelManager Instance;
    public int trueSquares = 0;


    private void Awake()
    {
        if (Instance != null)
        {
            Destroy(this);
            return;
        }
        Instance = this;
    }


    public Levels[] LevelScriptables;
    public GameObject[] Squares = new GameObject[9];
    //[SerializeField] private int trueSquare = 0;

    public GameObject YouWinCanvas;

    public void CheckLevelControl()
    {
        for (int i = 0; i < Squares.Length; i++)
        {
            if (LevelScriptables[LevelDataManager.Level - 1].colorDatas[i] == Squares[i].GetComponent<SquareController>().colorData)
            {
                trueSquares++;
            }
        }

        if (trueSquares == Squares.Length)
        {
            Debug.Log("All squares are true");
            YouWinCanvas.SetActive(true);
              
            

            if (LevelDataManager.Level == LevelScriptables.Length)
            {
                LevelDataManager.Level = 0;
            }
        }
        else
        {
            Debug.Log("Not yet");
        }
    }

}
