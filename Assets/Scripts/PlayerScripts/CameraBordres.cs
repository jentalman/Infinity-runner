using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraBordres : MonoBehaviour
{
    [SerializeField] private Transform _playerTransform;
    [SerializeField] private PlayerMover _playerMover;
    [SerializeField] private float _padding;
    private float _xMin;
    private float _xMax;
    private float _yMin;
    private float _yMax;

    private void OnEnable()
    {
        _playerMover.CheckBordres += ClampPosition;
    }
    private void OnDisable()
    {
        _playerMover.CheckBordres -= ClampPosition;
    }

    private void Start()
    {
        Bordres();
    }
    private void Bordres()
    {
        Camera _camera = Camera.main;
        _xMin = _camera.ViewportToWorldPoint(new Vector3(0, 0, 0)).x + _padding;
        _xMax = _camera.ViewportToWorldPoint(new Vector3(1, 0, 0)).x - _padding;
        _yMin = _camera.ViewportToWorldPoint(new Vector3(0, 0, 0)).y + _padding;
        _yMax = _camera.ViewportToWorldPoint(new Vector3(0, 1, 0)).y - _padding;
    }

    private void ClampPosition()
    {
        Vector3 clampedPos = _playerTransform.position;
        clampedPos.x = Mathf.Clamp(clampedPos.x, _xMin, _xMax);
        clampedPos.y = Mathf.Clamp(clampedPos.y, _yMin, _yMax);
        _playerTransform.position = clampedPos;
    }
}
