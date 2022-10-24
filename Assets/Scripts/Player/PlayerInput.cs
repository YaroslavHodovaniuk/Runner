using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class PlayerInput : MonoBehaviour, IBeginDragHandler, IDragHandler
{
    [SerializeField] private PlayerMover _playerMover;

    public void OnBeginDrag(PointerEventData eventData)
    {
        if (eventData.delta.x > 0)
            _playerMover.TryMoveRigth();
            
        if(eventData.delta.x < 0)
            _playerMover.TryMoveLeft();
    }

    public void OnDrag(PointerEventData eventData)
    {
    }
}
