
using UnityEngine;

public class groundtile : MonoBehaviour
{
    groundspwaner groundSpawner;
    
    void Start()
    {
        groundSpawner = GameObject.FindObjectOfType<groundspwaner>();
    }
    private void OnTriggerExit(Collider other)
    {
        if(other .gameObject.tag == ("Player"))
        {
            groundSpawner.SpawnTiles();
            Destroy(gameObject, 10);
        }
    }

  
    void Update()
    {
        
    }
}
