using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonController : MonoBehaviour
{
    public TopLeftImage topLeftImage;
    public GameObject LevelShowCanvas;


    public void OnClickPlayButton()
    {
        UILevelController.Instance.ShowLevelText();
        LevelShowCanvasManager.Instance.StartCanvas();
        LevelShowCanvasManager.Instance.isShowingCanvas = true;
        LevelShowCanvasManager.Instance.ShowCanvas();
        LevelShowCanvasManager.Instance.isShowingCanvas = true;
        topLeftImage.ShowTopLeftImage();
        gameObject.SetActive(false);        
        LevelShowCanvas.SetActive(true);
    }

    public void OnClickNextButton()
    {

        LevelDataManager.Level++;
        UILevelController.Instance.ShowLevelText();

        LevelShowCanvasManager.Instance.StartCanvas();
        LevelShowCanvasManager.Instance.isShowingCanvas = true;
        LevelShowCanvasManager.Instance.ShowCanvas();
        LevelShowCanvasManager.Instance.isShowingCanvas = true;
        LevelManager.Instance.trueSquares = 0;
        topLeftImage.ShowTopLeftImage();
        gameObject.SetActive(false);
        LevelShowCanvas.SetActive(true);

        for (int i = 0; i < 9; i++)
        {
            LevelManager.Instance.Squares[i].GetComponent<MeshRenderer>().material.color = Color.white;
        }
    }
}
