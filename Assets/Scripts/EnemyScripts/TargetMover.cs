using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetMover : EnemyMover
{
    private Transform _target;

    private void Start()
    {
        _target = FindObjectOfType<Player>().transform ;
    }

    private void Update()
    {
        Move(Vector2.MoveTowards(transform.position, _target.position, Speed * Time.deltaTime));
    }

    protected override void Move(Vector2 movement)
    {
        transform.position = movement;
    }
}
