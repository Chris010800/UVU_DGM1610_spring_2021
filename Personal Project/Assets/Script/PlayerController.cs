using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private float speed = 3.0f;
    private Rigidbody playerRb;
    bool gameover;
    public int pointValue;

    private GameManager gameManager;
    private SpawnManager spawnManager;
   
    

    // Start is called before the first frame update
    void Start()
    {
        playerRb = GetComponent<Rigidbody>();

        spawnManager = GameObject.Find("Spawn Manager").GetComponent<SpawnManager>();
        gameManager = GameObject.Find("Game Manager").GetComponent<GameManager>();
    }

    // Update is called once per frame
    void Update()
    {
        PlayerMovement();
    }

    void PlayerMovement()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");

        playerRb.AddForce(Vector3.forward * speed * verticalInput);
        playerRb.AddForce(Vector3.right * speed * horizontalInput);
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Goal"))
        {
            Destroy(other.gameObject);
            gameManager.UpdateScore(pointValue);   
        } 
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Enemie"))
        {
            Debug.Log("Game Over");
            spawnManager.GameOver();
        }
    }
}