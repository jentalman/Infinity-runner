using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInput : MonoBehaviour
{

    private float _moveHorizontal;
    private float _moveVertical;

 
    public void PlayerInputMovement(out Vector2 movement)
    {
        _moveHorizontal = Input.GetAxis("Horizontal");
        _moveVertical = Input.GetAxis("Vertical");
        movement = new Vector2(_moveHorizontal, _moveVertical);
    }
}
