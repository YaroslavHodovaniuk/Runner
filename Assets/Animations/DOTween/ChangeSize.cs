using DG.Tweening;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeSize : MonoBehaviour
{
    private void Start()
    {
        transform.DOScale(0.75f, 1).SetLoops(-1, LoopType.Yoyo);
    }
}
