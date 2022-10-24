using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Pause : MonoBehaviour
{
    [SerializeField] private Image _imageRenderer;
    [SerializeField] private Sprite _imagePause;
    [SerializeField] private Sprite _imagePlay;

    private bool IsPaused = true;
    public void OnPause()
    {
        if (IsPaused)
        {
            Time.timeScale = 0;
            IsPaused = false;
            _imageRenderer.sprite = _imagePlay;
        }
        else
        {
            Time.timeScale = 1;
            IsPaused = true;
            _imageRenderer.sprite = _imagePause;
        }
    }
}
