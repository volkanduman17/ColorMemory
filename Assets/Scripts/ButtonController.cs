using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonController : MonoBehaviour
{
    public GameObject levelShowCanvas;
    public void OnClickPlayButton()
    {

        CanvasManager.Instance.StartCanvas();
        CanvasManager.Instance.isShowingCanvas = true;
        CanvasManager.Instance.ShowCanvas();
        CanvasManager.Instance.isShowingCanvas = true;

        gameObject.SetActive(false);
        
        levelShowCanvas.SetActive(true);
    }
}
