using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

[RequireComponent(typeof(Rigidbody2D),typeof(PlayerInput))]
public class PlayerMover : Mover
{
    
    
    public event UnityAction CheckBordres;
    private Rigidbody2D _rigidbody2D;
    private PlayerInput _playerInput;

    private void Start()
    {
        _rigidbody2D = GetComponent<Rigidbody2D>();
        _playerInput = GetComponent<PlayerInput>();
    }
    private void Update()
    {
        _playerInput.PlayerInputMovement(out Vector2 movement);
        Move(movement);
    }

    protected override void Move(Vector2 movement)
    {
        _rigidbody2D.AddForce(movement * Speed * Time.deltaTime, ForceMode2D.Force);
        _rigidbody2D.velocity = Vector2.zero;
        CheckBordres?.Invoke();
    }
}
