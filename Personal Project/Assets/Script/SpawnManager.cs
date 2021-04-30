using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] enemies;
    public GameObject goal;
    private PlayerController playerController;
    public bool isGameActive;

    private float spawnZ = 8;
    private float spawnX = 22;
    private float startDelay = 1;
    private float enemySpawnTime = 1;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnEnemy", startDelay, enemySpawnTime);
        isGameActive = true;
        
    }

    // Update is called once per frame
    void Update()
    {
        SpawnGoal();
    }

    Vector3 GenerateSpawnPosition ()
    {
        float xPos = Random.Range(-spawnX, spawnX);
        float zPos = Random.Range(-spawnZ, spawnZ);

        return new Vector3(xPos, 1, zPos);
    }

    void SpawnGoal()
    {
            if (isGameActive = true && GameObject.FindGameObjectsWithTag("Goal").Length == 0)
            {
                Instantiate(goal, GenerateSpawnPosition(), goal.transform.rotation);
            }
        
    }

    void SpawnEnemy()
    {
        if (isGameActive == false)
        {
            float randomZ = Random.Range(-spawnZ, spawnZ);
            int randomIndex = Random.Range(0, enemies.Length);

            Vector3 spawnPos = new Vector3(-spawnX, 1, randomZ);

            Instantiate(enemies[randomIndex], spawnPos, enemies[randomIndex].gameObject.transform.rotation);
        }
        
    }
    public void GameOver()
    {
        isGameActive = false;
    }
}
