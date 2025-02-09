﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(RawImage))]
public class Parallax : MonoBehaviour
{
    [SerializeField] private float _speed;

    private float _imagePositionX;
    private RawImage _image;

    private void Start()
    {
        _image = GetComponent<RawImage>();
        _imagePositionX = _image.uvRect.x;
    }

    private void Update()
    {
        MoveBackground();
    }

    private void MoveBackground()
    {
        _imagePositionX += _speed * Time.deltaTime;
        if (_imagePositionX > 1)
            _imagePositionX = 0;
        _image.uvRect = new Rect(_imagePositionX, 0, _image.uvRect.width, _image.uvRect.height);
    }
}
