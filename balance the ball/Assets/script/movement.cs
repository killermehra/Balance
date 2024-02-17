using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement : MonoBehaviour
{
    public float speed;
    public FixedJoystick Joystick;
    public Rigidbody rb;
    public float jumpforce;
    public Transform cameraMain;

    private void Start()
    {
        cameraMain = Camera.main.transform; 
       
    }
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            jump();
        }
    }
    public void FixedUpdate()
    {
        move1();
    }
    public void jump()
    {
        rb.AddForce(Vector3.up * jumpforce, ForceMode.Impulse);

    }
  
    public void move1()
    {
        Vector3 direction = cameraMain.forward * Joystick.Vertical + cameraMain.right * Joystick.Horizontal;
        direction.y = 0;

        rb.AddForce(direction * speed * Time.fixedDeltaTime, ForceMode.VelocityChange);


    }
}
