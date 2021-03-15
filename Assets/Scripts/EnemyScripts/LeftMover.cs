using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeftMover : Mover
{

    private void Update()
    {
        Move(Vector3.left);
    }

    protected override void Move(Vector2 movement)
    {
        transform.Translate(movement * Speed * Time.deltaTime);
    }
}
