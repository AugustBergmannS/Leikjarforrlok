﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float horizontalInput;
    public float speed = 10.0f;
    public float Boundary = 10.0f;
    public GameObject projectilePrefab;


    void Update()
    {
        if (transform.position.x < -Boundary)
        {
            transform.position = new Vector3(-Boundary, transform.position.y, transform.position.z);
        }
        if (transform.position.x > Boundary)
        {
            transform.position = new Vector3(Boundary, transform.position.y, transform.position.z);
        }
        horizontalInput = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.right * horizontalInput * Time.deltaTime * speed);
        if (Input.GetKeyDown(KeyCode.Space))
        {
            // Launch a projectile from the player
            Instantiate(projectilePrefab, transform.position, projectilePrefab.transform.rotation);
        }
    }
}
