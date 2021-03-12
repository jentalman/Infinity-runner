using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMover : MonoBehaviour
{
    [SerializeField] private float _speed;

    private void Update()
    {
        MoveEnemy();   
    }

    protected virtual void MoveEnemy()
    {
        transform.Translate(Vector2.left * _speed * Time.deltaTime);
    }
}
