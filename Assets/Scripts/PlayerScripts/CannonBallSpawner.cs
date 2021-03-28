using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CannonBallSpawner : ObjectPool
{
    [SerializeField] private GameObject _cannonBallPrefab;

    private void Awake()
    {
        Initialize(_cannonBallPrefab);
    }
}
