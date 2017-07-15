﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paddle : MonoBehaviour
{
    public bool autoPlay = false;

    private Ball ball;

    private const float xMinPos = 0.8f;
    private const float xMaxPos = 15.2f;

    void Start()
    {
        ball = GameObject.FindObjectOfType<Ball>();
        print(ball);
    }
	
    // Update is called once per frame
    void Update()
    {
        if (!autoPlay)
        {
            MoveWithMouse(); 
        }
        else
        {
            AutoPlay();
        }
    }

    void AutoPlay()
    {
        Vector3 paddlePos = new Vector3(0.5f, this.transform.position.y, 0f);
        Vector3 ballPos = ball.transform.position;
        paddlePos.x = Mathf.Clamp(ballPos.x, xMinPos, xMaxPos);
        this.transform.position = paddlePos;
    }

    void MoveWithMouse()
    {
        Vector3 paddlePos = new Vector3(0.5f, this.transform.position.y, 0f);
        float mousePosInBlocks = Input.mousePosition.x / Screen.width * 16;
        paddlePos.x = Mathf.Clamp(mousePosInBlocks, xMinPos, xMaxPos);
        this.transform.position = paddlePos;
    }
}
