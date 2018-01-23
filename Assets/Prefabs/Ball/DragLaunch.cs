﻿using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Ball))]
public class DragLaunch : MonoBehaviour {
    private float startTime;
    private Vector3 startMousePosition;
    private Ball ball;

	// Use this for initialization
	void Start () {
        ball = GetComponent<Ball>();
	}

    public void DragStart()
    {
        startTime = Time.time;
        startMousePosition = Input.mousePosition;
    }

    public void DragEnd()
    {
        float dragDuration = (Time.time - startTime);
        Vector3 endMousePosition = (Input.mousePosition - startMousePosition);

        float launchForceZ = (endMousePosition.y / dragDuration) / 10;
        float launchForceX = endMousePosition.x / 50;

        Vector3 launchForce = new Vector3(launchForceX, 0, Mathf.Clamp(launchForceZ, 0, 180));

        ball.Launch(launchForce);
    }
}
