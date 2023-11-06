using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private float speed = 20.0f;

    private float turnSpeed = 45.0f;

    private float horizontalInput;

    private float forwardInput;

    public Camera MainCamera;

    public Camera HoodCamera;

    public KeyCode switchKey;

    public string inputID;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal" + inputID);
        forwardInput = Input.GetAxis("Vertical" + inputID);
        // Moves the car forward based on vertical input
        transform.Translate(Vector3.forward * Time.deltaTime * speed * forwardInput);
        // Rotates the car based on horizontal input
        //transform.Translate(Vector3.right * Time.deltaTime * turnSpeed * horizontalInput);
        transform.Rotate(Vector3.up, Time.deltaTime * turnSpeed * horizontalInput);
        
        //Camera Switcher
        if (Input.GetKeyDown(switchKey))
        {
            MainCamera.enabled = !MainCamera.enabled;
            HoodCamera.enabled = !HoodCamera.enabled;
        }
        
    }
}
