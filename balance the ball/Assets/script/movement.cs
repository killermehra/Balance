using System.Collections;
using System.Collections.Generic;
using UnityEditor.Rendering;
using UnityEngine;

public class movement : MonoBehaviour
{
    public float speed;
    public FixedJoystick Joystick;
    public Rigidbody rb;
    public float jumpforce;
    public Transform cameraMain;
    public AudioSource jumpsSound;
    public AudioClip jumpplay;
    private bool isGrounded = true;
    private bool jumpactivate;
    public Animator animjump;
    public float Dashspeed;
   // [SerializeField] private float onGroundGravity;
   // [SerializeField] private float inAirGravity;

    private void Awake()
    {
        rb = GetComponent<Rigidbody>();
       
    }


    private void Start()
    {
        cameraMain = Camera.main.transform;
        jumpsSound = GetComponent<AudioSource>();
        jumpactivate = false;
    }
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            jump();
        }
      
    
}
    private void PlayLandingSound()
    {
        
        if (jumpsSound!= null&& jumpplay!=null)
        {

            jumpsSound.PlayOneShot(jumpplay);
        }
    }




    public void FixedUpdate()
    {
        move1();
    }
    public void jump()
    {
       // if (rb.velocity.y >= .1)
       // {
      //      Physics.gravity = new Vector3(0, -inAirGravity, 0);
      //  }
      //  else if (rb.velocity.y >= -.1)
      //  {
      //      Physics.gravity = new Vector3(0, -onGroundGravity, 0);
      //  }

        rb.AddForce(Vector3.up * jumpforce, ForceMode.Impulse);
        

    }
  
    public void move1()
    {
        Vector3 direction = cameraMain.forward * Joystick.Vertical + cameraMain.right * Joystick.Horizontal;
        direction.y = 0;

        rb.AddForce(direction * speed * Time.fixedDeltaTime, ForceMode.VelocityChange);


    }
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("jump"))
        {

            jumpactivate = true;
            jump();
        }
        else if(other.gameObject.CompareTag("superjump"))
        {
            rb.AddForce(Vector3.up * 50, ForceMode.Impulse);
        }
       
    }
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.CompareTag("ground"))
        {
            if (isGrounded && jumpactivate)
            {

               
                animjump.Play("jump");
             PlayLandingSound();
                
            }
        }
    }


    public void Dash()
    {
       
        rb.velocity = new Vector3(0,0,transform.localScale.y * Dashspeed);
    }

    private void OnTriggerStay(Collider other)
    {
        if(other.gameObject.CompareTag("speed"))
        {
            Dash();
        }
    }
}
