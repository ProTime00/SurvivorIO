using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovment : MonoBehaviour
{
    public Joystick joystick;

    private void FixedUpdate()
    {
        Vector3 dir = Vector3.zero;
        dir.x = joystick.Horizontal / 3;
        dir.z = joystick.Vertical / 3;
        transform.Translate(dir);
    }
}
