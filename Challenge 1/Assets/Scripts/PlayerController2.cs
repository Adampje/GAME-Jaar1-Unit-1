using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController2 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame

    private float speed = 20;
    private float forwardInput;
    private float upInput;
    private float downInput;


    void Update()
    {
        // Moves the vehicle forward
        forwardInput = Input.GetAxis("Vertical");

        // Moves the vehicle up and down
        upInput = Input.GetAxis("Horizontal");
        downInput = Input.GetAxis("");
        // Moves the plane forward based on vertical input
        transform.Translate(Vector3.forward * Time.deltaTime * speed * forwardInput);
        // Moves the plane up and down based on Horizontal input
        transform.Rotate(Vector3.up, upInput * Time.deltaTime);
        transform.Rotate(Vector3.up, downInput * Time.deltaTime);




    }
}
