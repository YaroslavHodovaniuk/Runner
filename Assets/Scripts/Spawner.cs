using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : ObjectPool
{
    [SerializeField] private GameObject[] _enemyTemplates;
    [SerializeField] private float _secondsBetweenSpawn; //save
    [SerializeField] private Transform[] _spawnPoints;
    [SerializeField] private float _maxSpawnTime;
    [SerializeField] private float _subtractTime;

    private float _elapsedTime = 0;
    private void Awake()
    {
        Initialize(_enemyTemplates);
    }
    private void Update()
    {
        _elapsedTime += Time.deltaTime;

        if(_elapsedTime >= _secondsBetweenSpawn)
        {
            if (TryGetObject(out GameObject enemy))
            {
                _elapsedTime = 0;

                int spawnPointNumber = Random.Range(0, _spawnPoints.Length);
                SetEnemy(enemy, _spawnPoints[spawnPointNumber].position);
            }
            if (_secondsBetweenSpawn > _maxSpawnTime)
                _secondsBetweenSpawn -= _subtractTime;
        }
    }

    private void SetEnemy(GameObject enemy, Vector3 spawnpoint)
    {
        enemy.SetActive(true);
        enemy.transform.position = spawnpoint;
    }


}
