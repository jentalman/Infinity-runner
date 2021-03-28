using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : ObjectPool
{
    [SerializeField] private Transform[] _spawnPoints;
    [SerializeField] private GameObject _enemyPrefab;
    [SerializeField] private GameObject[] _enemyTemplate;
    [SerializeField] private float _timeBetweenSpawns;


    private float _elapsedTime;

    private void Awake()
    {
        Initialize(_enemyTemplate);
    }

    private void Update()
    {
        _elapsedTime += Time.deltaTime;

        if (_elapsedTime >= _timeBetweenSpawns)
        {
            if (TryGetObjectFromPool(out GameObject enemy))
            {
                _elapsedTime = 0;
                int spawnPointNumber = Random.Range(0, _spawnPoints.Length);
                SetEnemy(enemy, _spawnPoints[spawnPointNumber].position);
            }
        }
    }
    private void SetEnemy(GameObject enemy, Vector3 spawnPoint)
    {
        enemy.SetActive(true);
        enemy.transform.position = spawnPoint;
    }
}
