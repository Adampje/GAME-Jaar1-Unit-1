using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame

    private float speed = 20;
    private float direction;
    private float forwardInput;
    void Update()
    {
        // Move the vehicle forward
        forwardInput = Input.GetAxis("Vertical");
        direction = Input.GetAxis("Horizontal");
        // Moves the car forward based on vertical input
        transform.Translate(Vector3.forward * Time.deltaTime * speed * forwardInput);
        // Rotates the car based on horizontal input
        transform.Rotate(Vector3.up, direction * Time.deltaTime);
    }
}
