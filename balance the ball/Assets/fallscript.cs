using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fallscript : MonoBehaviour
{
    private Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        rb.useGravity = false;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            StartCoroutine(fall());
            Destroy(gameObject, 8);
        }
    }
    IEnumerator fall()
    {
       
        yield return new WaitForSeconds(5f);
        rb.useGravity = true;
                                 
    }
}
