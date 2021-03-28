using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class EnemyMover : MonoBehaviour
{
    [SerializeField] private float _speed;
    public float Speed 
    { 
        get { return _speed; } 
    }

    protected abstract void Move(Vector2 movement);
}
