using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class loose : MonoBehaviour
{
    public GameObject fail;
    
    void Start()
    {
        fail.SetActive(false);
    }
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("ground"))
        {

            fail.SetActive(true);
            Time.timeScale = 0f;
        }
    }
    public void restart()
    {
        SceneManager.LoadScene(1);
        Time.timeScale = 1f;
    }

}
