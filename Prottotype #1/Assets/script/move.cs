using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move : MonoBehaviour
{
    // Access Modifier, Data Type, Name
    [SerializeField] private float speed = 15.0f;
    [SerializeField] private float turnSpeed = 35.0f;
    private float hInput;
    private float fInput;

    /// </summary>
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // this is where we get player input
        hInput = Input.GetAxis("Horizontal");
        fInput = Input.GetAxis("Vertical");
       
        // we move the vehicle forward
        transform.Translate(Vector3.forward * Time.deltaTime * speed * fInput);
        // we turn the vehicle 
        transform.Rotate(Vector3.up, turnSpeed * hInput * Time.deltaTime);
    }
}
