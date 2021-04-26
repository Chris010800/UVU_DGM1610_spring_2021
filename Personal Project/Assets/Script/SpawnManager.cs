using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] enemies;
    public GameObject goal;
    private float spawnZ = 8;
    private float spawnX = 24;

    // Start is called before the first frame update
    void Start()
    {
        SpawnGoal();
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
        if(GameObject.FindGameObjectsWithTag("Goal").Length == 0)
        {
            Instantiate(goal, GenerateSpawnPosition(), goal.transform.rotation);
        }
    }
}
