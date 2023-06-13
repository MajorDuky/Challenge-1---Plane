﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    private float speed;
    private float rotationSpeed;
    public float verticalInput;

    // Start is called before the first frame update
    void Start()
    {
        speed = 20f;
        rotationSpeed = 150;
    }

    // Update is called once per frame
    void Update()
    {
        // get the user's vertical input
        verticalInput = Input.GetAxis("Vertical");

        // move the plane forward at a constant rate
        transform.Translate(Vector3.forward * speed * Time.deltaTime);

        // tilt the plane up/down based on up/down arrow keys
        if(verticalInput != 0)
        {
            transform.Rotate(Vector3.right, rotationSpeed * Time.deltaTime * verticalInput);
        }
    }
}
