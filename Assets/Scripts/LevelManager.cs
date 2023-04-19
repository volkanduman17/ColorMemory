using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelManager : MonoBehaviour
{
    public static LevelManager Instance;

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
    [SerializeField] private int trueSquare = 0;

    public GameObject YouWinCanvas;


    public void CheckLevelControl()
    {
        int trueSquares = 0;
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
        }
        else
        {
            Debug.Log("Not yet");
        }
    }

}
