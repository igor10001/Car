using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    //Private variables
    public float speed = 15.0f;
    public float turnSpeed = 25.0f;
    public float horizontalInput;
    public float forwardInput;
    public bool test;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
        horizontalInput = Input.GetAxis("Horizontal");
        forwardInput = Input.GetAxis("Vertical");
            

        
        if (forwardInput > 0)
        {
            // Move the vehicle forward based on vertical input
            transform.Translate(Vector3.forward * Time.deltaTime * speed * forwardInput);
            //Rotates the car based on horizontal input
            transform.Rotate(Vector3.up * Time.deltaTime * turnSpeed * horizontalInput);
        }
    }
}
