using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class followcam : MonoBehaviour
{
    public Transform target;
    public float followSpeed = 5f;
    public  Vector3 offset;
    private void Start()
    {
        offset = transform.position - target.position;
    }

    private void Update()
    {
        transform.position = new Vector3(target.position.x+offset.x,target.position.y+offset.y ,target.position.z+offset.z);
    }
}
