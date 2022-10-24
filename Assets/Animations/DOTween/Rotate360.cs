using DG.Tweening;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate360 : MonoBehaviour
{
    private void Start()
    {
        transform.DORotate(new Vector3(0,0,55), 0.5f).SetLoops(-1, LoopType.Incremental).SetEase(Ease.Linear).SetOptions(true);
    }
}
