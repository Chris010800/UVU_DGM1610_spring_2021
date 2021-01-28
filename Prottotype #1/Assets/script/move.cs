﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move : MonoBehaviour
{
    // Access Modifier, Data Type, Name
    public float speed = 30.0f;
    public float turnSpeed = 35.0f;
    public float hInput;
    public float fInput;

    /// </summary>
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        hInput = Input.GetAxis("Horizontal");
        fInput = Input.GetAxis("Vertical");
       
        transform.Translate(Vector3.forward * Time.deltaTime * speed * fInput);
        transform.Rotate(Vector3.up, turnSpeed * hInput * Time.deltaTime);
    }
}
