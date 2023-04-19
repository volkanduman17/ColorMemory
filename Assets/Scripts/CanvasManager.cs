using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class CanvasManager : MonoBehaviour
{
    public static CanvasManager Instance;

    private void Awake()
    {
        if (Instance != null)
        {
            Destroy(this);
            return;
        }
        Instance = this;
    }

    public Canvas Canvas;
    public Image ProgressBar;
    public TextMeshProUGUI TimerText;

    private float timeLeft = 5f;
    private float timerMax = 5f;
    public bool isShowingCanvas = false;

    public void StartCanvas()
    {
         Canvas.enabled = true;
        
         ShowCanvasFor5Seconds();
           
       
    }

    private void Update()
    {
        // Eðer canvas gösteriliyorsa, geri sayým yap
        if (isShowingCanvas)
        {
            timeLeft -= Time.deltaTime;
            TimerText.text = Mathf.RoundToInt(timeLeft).ToString();
            ProgressBar.fillAmount = timeLeft / timerMax;

            // Geri sayým tamamlandý, canvas kapat
            if (timeLeft <= 0)
            {
                Canvas.enabled = false;
                isShowingCanvas = false;
            }
        }
    }

    public void ShowCanvas()
    {
        // Canvas'ý göster
        Canvas.enabled = true;
        isShowingCanvas = true;

        // Geri sayým için deðiþkenleri ayarla
        timeLeft = timerMax;
        TimerText.text = Mathf.RoundToInt(timeLeft).ToString();
        ProgressBar.fillAmount = 1f;
    }

    private void HideCanvas()
    {
        // Canvas'ý gizle
        Canvas.enabled = false;
        isShowingCanvas = false;
    }

    // Örneðin start fonksiyonunda bu metod çaðrýlabilir
    public void ShowCanvasFor5Seconds()
    {
        ShowCanvas();
        Invoke("HideCanvas", 5f);
    }

}