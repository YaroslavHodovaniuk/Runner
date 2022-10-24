using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class Play : MonoBehaviour
{
    [SerializeField] private GameObject[] _offObjects;
    [SerializeField] private GameObject[] _onObjects;
    [SerializeField] private Parallax[] _parallaxs;
    [SerializeField] private Animator _animator;

    public void StartPlay()
    {
        foreach (var obj in _offObjects)
            obj.SetActive(false);

        foreach (var obj in _onObjects)
            obj.SetActive(true);

        foreach (var parallax in _parallaxs)
            parallax.enabled = true;
        

        _animator.SetBool("Started", true);
    }
}
