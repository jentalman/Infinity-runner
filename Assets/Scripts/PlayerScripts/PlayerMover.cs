using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
[RequireComponent(typeof(PlayerInput))]
public class PlayerMover : MonoBehaviour
{
    [SerializeField] private float _speed;

    private Rigidbody2D _rigidbody2D;
    private PlayerInput _playerInput;
    private Vector2 movement;

    private void Start()
    {
        _rigidbody2D = GetComponent<Rigidbody2D>();
        _playerInput = GetComponent<PlayerInput>();
    }
    private void Update()
    {
        _playerInput.PlayerInputMovement(out movement);
        PlayerMove(movement);
    }

    private void PlayerMove(Vector2 movement)
    {
        _rigidbody2D.AddForce(movement * _speed * Time.deltaTime, ForceMode2D.Force);
        _rigidbody2D.velocity = Vector2.zero;
    }
}
