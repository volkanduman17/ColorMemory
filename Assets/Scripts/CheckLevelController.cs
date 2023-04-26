using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using UnityEngine.UI;

public class CheckLevelController : MonoBehaviour
{
    public LevelManager levelManager;
    public Image circleProgressBar;
    private Tweener fillTweener;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("CheckButton"))
        {
            StartFill();
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("CheckButton"))
        {
            StopFill();
        }
    }

    private void StartFill()
    {
        fillTweener = circleProgressBar.DOFillAmount(1, 1.5f).OnComplete(() =>
        {
            levelManager.CheckLevelControl();
        });
    }

    private void StopFill()
    {
        if (fillTweener != null)
        {
            fillTweener.Kill();
        }
        circleProgressBar.fillAmount = 0;
    }
}
