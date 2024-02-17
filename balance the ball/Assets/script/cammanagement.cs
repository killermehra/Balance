using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cammanagement : MonoBehaviour
{

    public GameObject cam1;
    public GameObject cam2;
    public  movement move;
    public move2 move2;

    // Start is called before the first frame update
    void Start()
    {
        move = GetComponent<movement>();
        move2 = GetComponent<move2>();


        cam2.SetActive(false);
        move2.enabled = false;
     
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
        else
        {
            cam1.SetActive(true);
            move.enabled = true;

        }
    }
}
