using UnityEngine;


public class groundspwaner : MonoBehaviour
{
    public GameObject[] groundTile;
    Vector3 nextspwanpoint;
     public  void SpawnTiles()
    {
        int tiles = Random.Range(0, groundTile.Length);
       GameObject temp = Instantiate(groundTile[tiles], nextspwanpoint, Quaternion.identity);
        nextspwanpoint = temp.transform.GetChild(1).transform.position;
    }
    void Start()
    { for(int i = 0;i < 2; i++)
        {
            SpawnTiles();
        }
      
    }




}