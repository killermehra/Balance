using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cammanagement : MonoBehaviour
{

    public GameObject cam1;
    public GameObject cam2;
    public  movement move;
    public move2 move2;
    public Joystick joystick;

    // Start is called before the first frame update
    void Start()
    {
        move = GetComponent<movement>();
        move2 = GetComponent<move2>();


        cam2.SetActive(false);
        move2.enabled = false;
     
    }


    public void Update()
    {
        if (joystick.Vertical >= 1)
        {
            cam1.SetActive(true);
            cam2.SetActive(false);

        }else if (joystick.Vertical <= -1)
        {
            cam1.SetActive(false);
                cam2.SetActive(true);
        }
        if(joystick.Horizontal >= 1)
        {
            cam2.SetActive(true);
            cam1.SetActive(false);
        }
    }




    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("camchange"))
        {
            cam1.SetActive(false);
            cam2.SetActive(true);
            move.enabled = false;
            move2.enabled = true;
        }
        else if (other.gameObject.CompareTag("camchange2"))
        {
            cam1.SetActive(true);
            move.enabled = true;
            move2.enabled = false;
            cam2.SetActive(false);

        }
    }
    
}
