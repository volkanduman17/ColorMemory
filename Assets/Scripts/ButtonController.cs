using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonController : MonoBehaviour
{
    public GameObject LevelShowCanvas;
    public void OnClickPlayButton()
    {

        CanvasManager.Instance.StartCanvas();
        CanvasManager.Instance.isShowingCanvas = true;
        CanvasManager.Instance.ShowCanvas();
        CanvasManager.Instance.isShowingCanvas = true;

        gameObject.SetActive(false);
        
        LevelShowCanvas.SetActive(true);
    }

    public void OnClickNextButton()
    {
        LevelDataManager.Level++;
        CanvasManager.Instance.StartCanvas();
        CanvasManager.Instance.isShowingCanvas = true;
        CanvasManager.Instance.ShowCanvas();
        CanvasManager.Instance.isShowingCanvas = true;

        gameObject.SetActive(false);

        LevelShowCanvas.SetActive(true);

        for (int i = 0; i < 9; i++)
        {
            LevelManager.Instance.Squares[i].GetComponent<MeshRenderer>().material.color = Color.white;

        }


    }
}
