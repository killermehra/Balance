using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cammanagement : MonoBehaviour
{

    public GameObject cam1;
    public GameObject cam2;

    // Start is called before the first frame update
    void Start()
    {
        cam2.SetActive(false);
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("camchange"))
        {
            cam1.SetActive(false);
            cam2.SetActive(true);
        }
        else
        {
            cam1.SetActive(true);

        }
    }
}
