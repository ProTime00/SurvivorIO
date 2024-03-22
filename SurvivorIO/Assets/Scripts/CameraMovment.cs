using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovment : MonoBehaviour
{
    public GameObject playerToFollow;

    private Transform _playerPosition;

    private void Awake()
    {
        _playerPosition = playerToFollow.transform;
    }

    private void FixedUpdate()
    {
        var transform1 = transform;
        Vector3 pos = transform1.position;
        var position = _playerPosition.position;
        pos.x = position.x;
        pos.z = position.z - 10;
        transform1.position = pos;
    }
}
