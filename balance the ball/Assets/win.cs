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
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.CompareTag("player"))
        {
            panlewin.SetActive(true);
            Time.timeScale = 0f;
        }
    }
    public void loadsceen()
    {
        SceneManager.LoadScene(0);
        Time.timeScale = 1f;
    }

}
