using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 10;
    public float turnSpeed = 50;
    public float horizontalInput;
    private float verticalInput;
    public Camera Maincamera;
    public Camera Hoodcamera;
    public  

    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        verticalInput = Input.GetAxis("Vertical");
        // Moves the car forward
        transform.Translate(Vector3.forward * Time.deltaTime * speed * verticalInput);
        // Turns the car on the Y axis
        transform.Rotate(Vector3.up * Time.deltaTime * turnSpeed * horizontalInput);

        if(Input.GetKeyDown(KeyCode.L))
        {
            Maincamera.enabled = !Maincamera.enabled;
            Hoodcamera.enabled = !Hoodcamera.enabled;

        }
        
    }
}
