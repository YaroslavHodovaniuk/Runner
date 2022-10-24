using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectMover : MonoBehaviour
{
    [SerializeField] private float _speed;

    private float _elapsedTime = 0;
    private void Update()
    {
        //_elapsedTime += Time.deltaTime;
        transform.Translate(Vector3.down * _speed * Time.deltaTime, Space.World);
    }
}
