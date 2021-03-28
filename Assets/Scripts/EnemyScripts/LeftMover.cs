using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeftMover : EnemyMover
{

    private void Update()
    {
        Move(Vector2.left);
    }

    protected override void Move(Vector2 movement)
    {
        transform.Translate(movement * Speed * Time.deltaTime);
    }
}
