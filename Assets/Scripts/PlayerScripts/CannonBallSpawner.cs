using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CannonBallSpawner : ObjectPool
{
    [SerializeField] private GameObject _cannonBallPrefab;
    [SerializeField] private Transform _cannonBallSpawnPoint;

    private void Start()
    {
        Initialize(_cannonBallPrefab);
    }

    
}
