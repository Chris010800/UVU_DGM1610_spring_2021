﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private float speed = 3.0f;
    private Rigidbody playerRb;
    private GameObject focalPoint;
    public bool hasPowerUp = false;
    private float powerUpStrength = 12.0f;
    public GameObject powerUpIndicator;

    // Start is called before the first frame update
    void Start()
    {
        playerRb = GetComponent<Rigidbody>();
        focalPoint = GameObject.Find("FocalPoint");
        
    }

    // Update is called once per frame
    void Update()
    {
        float forwardInput = Input.GetAxis("Vertical");

        playerRb.AddForce(focalPoint.transform.forward * forwardInput * speed);

        powerUpIndicator.transform.position = transform.position + new Vector3(0 ,-0.5f, 0);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("PowerUp"))
        {
            hasPowerUp = true;
            powerUpIndicator.gameObject.SetActive(true);
            Destroy(other.gameObject);
            StartCoroutine(PowerUpCountdownRoutine());

        }
    }

    IEnumerator PowerUpCountdownRoutine()
    {
        yield return new WaitForSeconds(7);
        hasPowerUp = false;
        powerUpIndicator.gameObject.SetActive(false);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Enemy") && hasPowerUp)
        {
            Rigidbody enemyRigidbody = collision.gameObject.GetComponent<Rigidbody>();
            Vector3 awayfromPlayer = collision.gameObject.transform.position - transform.position;

            enemyRigidbody.AddForce(awayfromPlayer * powerUpStrength, ForceMode.Impulse);
            Debug.Log("Collided with: " + collision.gameObject.name + " with powerup set to " + hasPowerUp);
        }
    }
}
