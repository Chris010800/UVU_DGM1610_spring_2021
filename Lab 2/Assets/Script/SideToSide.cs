using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SideToSide : MonoBehaviour
{
    private Rigidbody enemyRb;
    public float speed;
    private float xBound = 26;

    // Start is called before the first frame update
    void Start()
    {
        enemyRb = GetComponent<Rigidbody>();

    }

    // Update is called once per frame
    void Update()
    {
        //Moving the enemies
        enemyRb.AddForce(Vector3.right * speed);

        if (transform.position.x > xBound)
        {
            Destroy(gameObject);
        }

    }


}
