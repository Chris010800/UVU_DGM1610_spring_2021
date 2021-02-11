using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestrroyOutofBonds : MonoBehaviour
{
    public float topBound = 34;
    public float lowerBound = -14;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.z > topBound) 
        {
            Destroy(gameObject);
        }  
        else if(transform.position.z < lowerBound)
        {
            Debug.Log("GAME OVER!");
            Destroy(gameObject);
        }
    }
}
