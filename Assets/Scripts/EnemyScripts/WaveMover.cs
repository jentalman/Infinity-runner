using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaveMover : EnemyMover
{
    private float _amplitdueY;
    private float _positionYZero;

    private void Start()
    {
        _positionYZero = transform.position.y;
        _amplitdueY = Random.Range(1, 3);
    }

    private void Update()
    {
        Move(Vector2.left);
    }

    protected override void Move(Vector2 movement)
    {
        transform.Translate(movement * Speed * Time.deltaTime);
        Vector3 positionY = transform.position;
        positionY.y = _positionYZero + _amplitdueY * Mathf.Sin(Speed * Time.time);
        transform.position = positionY;
    }
}
