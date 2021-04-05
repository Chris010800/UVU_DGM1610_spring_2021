using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] enemies;
    public GameObject powerup;
    public GameObject goal;
 

    private float xRange = -22;
    private float zRange = -10;
    private float yRange = 0.5f;

    private float powerupSpawnTime = 4;
    private float enemySpawnTime = 1;
    private float StartDelay = 1;
    private float goalSpawnTime = 5;
   
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnEnemie", StartDelay, enemySpawnTime);
        InvokeRepeating("SpawnPowerup", StartDelay, powerupSpawnTime);
        InvokeRepeating("SpawnGoal", StartDelay, goalSpawnTime);
    }

    // Update is called once per frame
    void Update()
    {
      
    }

    void SpawnEnemie()
    {
        float randomZ = Random.Range(-zRange, zRange);
        int randomIndex = Random.Range(0, enemies.Length);

        Vector3 spawnpos = new Vector3(xRange, yRange,randomZ);

        Instantiate(enemies[randomIndex], spawnpos, enemies[randomIndex].gameObject.transform.rotation);
    }

    void SpawnPowerup()
    {
        float randomZ = Random.Range(-zRange, zRange);
        float randomX = Random.Range(-xRange, xRange);

        Vector3 spawnpos = new Vector3(randomX, 1, randomZ);
        Instantiate(powerup, spawnpos, powerup.gameObject.transform.rotation);

    }

    void SpawnGoal()
    {
        float randomZ = Random.Range(-zRange, zRange);
        float randomX = Random.Range(-xRange, xRange);

        Vector3 spawnpos = new Vector3(randomX, 1, randomZ);
        Instantiate(goal, spawnpos, goal.gameObject.transform.rotation);
    }

}
