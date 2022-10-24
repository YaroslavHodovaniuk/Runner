using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SoundManager : MonoBehaviour
{
    [SerializeField] private Image _imageRenderer;
    [SerializeField] private Sprite _imageOff;
    [SerializeField] private Sprite _imagePlay;
    [SerializeField] private GameObject _audio;

    private bool OnSound = false;
    public void TurnSound()
    {
        if (OnSound)
        {
            _audio.SetActive(true);
            OnSound = false;
            _imageRenderer.sprite = _imagePlay;
        }
        else
        {
            _audio.SetActive(false);
            OnSound = true;
            _imageRenderer.sprite = _imageOff;
        }
    }
}
