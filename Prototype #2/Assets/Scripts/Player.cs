﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float speed = 15.0f;
    public float hInput;
    public float xRange = 20;
    public GameObject projectilePrefab;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        hInput = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.right * hInput * Time.deltaTime * speed);

        if (transform.position.x < -xRange)
        { 
         transform.position = new Vector3(-xRange, transform.position.y, transform.position.z); 
        }
        if (transform.position.x > xRange) 
        { transform.position = new Vector3(xRange, transform.position.y, transform.position.z); }
        if (Input.GetKeyDown(KeyCode.Space)) 
        { // launch projectile
            Instantiate(projectilePrefab, transform.position, projectilePrefab.transform.rotation);
        }
    }
}
