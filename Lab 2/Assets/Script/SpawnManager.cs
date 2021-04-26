using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class SpawnManager : MonoBehaviour
{
    public GameObject[] enemies;
    public GameObject powerUp;
    public GameObject goal;
    private GameManage gameManage;

    private float xRange = -22;
    private float zRange = -10;
    private float yRange = 0.5f;

    private float powerupSpawnTime = 4;
    private float enemySpawnTime = 1;
    private float StartDelay = 1;
    private float goalSpawnTime = 5;
   
    // Start is called before the first frame update
    public void Start()
    {
        gameManage = GameObject.Find("Game Manager").GetComponent<GameManage>();

        SpawnEnemie();
        SpawnGoal();
        SpawnPowerup();
    }

    // Update is called once per frame
    void Update()
    {
      
    }

    Vector3 GenerateSpawnPosition()
    {
        float randomZ = Random.Range(-zRange, zRange);
        float randomX = Random.Range(-xRange, xRange);

        return new Vector3(randomX, 1, randomZ);
    }

    Vector3 GenerateEnemiePosition()
    {
        float randomZ = Random.Range(-zRange, zRange);
        return new Vector3(xRange, yRange, randomZ);
    }
    
    public void SpawnEnemie()
    {
        if (gameManage.isGameActive = true)
        {
            int randomIndex = Random.Range(0, enemies.Length);
            Instantiate(enemies[randomIndex], GenerateEnemiePosition(), enemies[randomIndex].transform.rotation);
        }
           
    }

    public void SpawnPowerup()
    {
        if (GameObject.FindGameObjectsWithTag("Powerup").Length == 0)
        {
            Instantiate(powerUp, GenerateSpawnPosition(), powerUp.transform.rotation);
        }

    }

    public void SpawnGoal()
    {
        if (GameObject.FindGameObjectsWithTag("Goal").Length == 0)
        {
            Instantiate(goal, GenerateSpawnPosition(), goal.transform.rotation);
        }
    }


}
