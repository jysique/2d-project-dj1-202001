﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBounds : MonoBehaviour
{
    private float minX, maxX;

    // Start is called before the first frame update
    void Start()
    {
        SetMinAndMax();
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.x < minX)
        {
            Vector2 temp = transform.position;
            temp.x = minX;
            transform.position = temp;
        }if (transform.position.x > maxX)
        {            
            Vector2 temp = transform.position;
            temp.x = maxX;
            transform.position = temp;
        }

    }
    void SetMinAndMax(){
        Vector3 bounds = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width,Screen.height,0));
        minX = -bounds.x;
        maxX = bounds.x;
    }
}
