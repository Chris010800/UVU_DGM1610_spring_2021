using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private float speed = 10.0f;
    private Rigidbody playerRb;
    private float zBound = 11.5f;
    private float xBound = 19.5f;
    
    // Start is called before the first frame update
    void Start()
    {
        playerRb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        MovePLayer();
        Bounderies();
       

       
        void MovePLayer()
        {
            float horizontalInput = Input.GetAxis("Horizontal");
            float verticalInput = Input.GetAxis("Vertical");

            playerRb.AddForce(Vector3.forward * speed * verticalInput);
            playerRb.AddForce(Vector3.right * speed * horizontalInput);
        }
        void Bounderies()
        {
            if (transform.position.z < -zBound)
            {
                transform.position = new Vector3(transform.position.x, transform.position.y, -zBound);
            }

            if (transform.position.z > zBound)
            {
                transform.position = new Vector3(transform.position.x, transform.position.y, zBound);
            }

            if (transform.position.x < -xBound)
            {
                transform.position = new Vector3(-xBound, transform.position.y, transform.position.z);
            }

            if (transform.position.x > xBound)
            {
                transform.position = new Vector3(xBound, transform.position.y, transform.position.z);
            }
        }
    }
}
