﻿using Assets.Scripts.Configuration;
using UnityEngine;

public class MouseRotationX : MonoBehaviour
{
    void Update()
    {
        var horizontalTurn = Input.GetAxis("Mouse X") * MouseConfiguration.MouseSensetivity * Time.deltaTime;
        transform.Rotate(0, horizontalTurn, 0);
    }
}