using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public GameObject dogPrefab;
    private float dogSpawnCooldown = 1.0f;
    private float timeElapsedSinceLastSpawn = 0.0f;

    // Update is called once per frame
    void Update()
    {
        //Every Frame, increment the timer since last spawn
        timeElapsedSinceLastSpawn += Time.deltaTime;
        // On spacebar press, send dog
        if (Input.GetKeyDown(KeyCode.Space) && timeElapsedSinceLastSpawn >= dogSpawnCooldown)
        {
            Instantiate(dogPrefab, transform.position, dogPrefab.transform.rotation);
            //When a dog is spawned, reset the timer
            timeElapsedSinceLastSpawn = 0.0f;
        }
    }
}
