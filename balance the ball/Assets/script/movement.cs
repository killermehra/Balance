using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement : MonoBehaviour
{
    public float speed;
    public VariableJoystick variableJoystick;
    public Rigidbody rb;
    public float jumpforce;
    private Transform cameraMain;

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
        Vector3 direction = cameraMain.forward * variableJoystick.Vertical + cameraMain.right * variableJoystick.Horizontal;
        direction.y = 0;
        rb.AddForce(direction * speed * Time.fixedDeltaTime, ForceMode.VelocityChange);
    }
    public void jump()
    {
        rb.AddForce(Vector3.up * jumpforce, ForceMode.Impulse);

    }
}
