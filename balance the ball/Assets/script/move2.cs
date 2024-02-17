using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move2 : MonoBehaviour
{


    public float speed;
    public FixedJoystick Joystick;
    public Rigidbody rb;
    public float jumpforce;
    public Transform cam2;

    private void Start()
    {
       
        cam2 = Camera.main.transform;
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
        movement2();
    }
    public void jump()
    {
        rb.AddForce(Vector3.up * jumpforce, ForceMode.Impulse);

    }
    public void movement2()
    {
        Vector3 move = cam2.right  * Joystick.Vertical + cam2.forward* -1 * Joystick.Horizontal;
        move.y = 0;
        rb.AddForce(move * speed * Time.fixedDeltaTime, ForceMode.VelocityChange);
    }
 
}
