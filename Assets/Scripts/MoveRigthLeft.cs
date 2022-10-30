using DG.Tweening;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveRigthLeft : MonoBehaviour
{
    private void Start()
    {
        transform.DOMoveX(1.5f, 1).SetLoops(-1, LoopType.Incremental).SetEase(Ease.Linear);
    }

}
