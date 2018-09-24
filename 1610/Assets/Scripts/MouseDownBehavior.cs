﻿using UnityEngine;
using UnityEngine.Events;

public class MouseDownBehavior : MonoBehaviour {

    public UnityEvent MouseDown;
    public UnityEvent MouseUp;

    private void OnMouseDown()
    {
        MouseDown.Invoke();
    }
}