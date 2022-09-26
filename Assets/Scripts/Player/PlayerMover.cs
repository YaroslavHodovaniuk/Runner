using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMover : MonoBehaviour
{
    [SerializeField] private float _moveSpeed;
    [SerializeField] private float _stepSize;
    [SerializeField] private SpriteRenderer _spriteRenderer;
    [SerializeField] private float _maxRigth;
    [SerializeField] private float _maxLeft;

    private Vector3 _targetPosition;
    private void Start()
    {
        _targetPosition = transform.position;
    }

    private void Update()
    {
        if (transform.position != _targetPosition)
            transform.position = Vector3.MoveTowards(transform.position, _targetPosition, _moveSpeed * Time.deltaTime);
    }

    public void TryMoveRigth()
    {
        if (_targetPosition.x < _maxRigth)
        {
            SetNextPosition(_stepSize);
            _spriteRenderer.flipX = false;
        }
    }

    public void TryMoveLeft()
    {
        if (_targetPosition.x > _maxLeft)
        {
            SetNextPosition(-_stepSize);
            _spriteRenderer.flipX = true;
        }
    }

    private void SetNextPosition(float stepSize)
    {
        _targetPosition = new Vector2(_targetPosition.x + stepSize, _targetPosition.y);
    }
}