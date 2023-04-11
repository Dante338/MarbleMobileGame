using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public float MoveSpeed = 15;

    Vector3 StartLocation = Vector3.zero; 
    Rigidbody rb; 

    void Start()
    {
        StartLocation = gameObject.transform.position; 
        rb = gameObject.GetComponent<Rigidbody>(); 
    }
 
    void Update()
    {
        Vector3 RawData = Input.acceleration;
        Vector3 GameWorldData = Vector3.zero;
        GameWorldData.x = RawData.x;
        GameWorldData.z = RawData.y;

        rb.AddForce(GameWorldData * MoveSpeed); 
    }

    public void Reset()
    {
         gameObject.transform.position = StartLocation;
        rb.velocity = Vector3.zero;
        rb.angularVelocity = Vector3.zero; 
    }
}
