using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class win : MonoBehaviour
{
    public GameObject panlewin;
    public void Start()
    {
        panlewin.SetActive(false);
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("Player"))
        {
            panlewin.SetActive(true);
           
        }
    }
    public void loadsceen()
    {
        SceneManager.LoadScene(0);
        Time.timeScale = 1f;
    }

}
