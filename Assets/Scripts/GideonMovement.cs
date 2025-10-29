using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GideonMovement : MonoBehaviour
{
    GameObject tentaclePrefab; 
    Rigidbody rb;

    int speed = 5;
    Vector3 movement = new Vector3(0,0,0);
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void FixedUpdate()
    {
        rb.velocity = movement * speed; 
    }

     void OnCollisionEnter(Collision other)
    {
        if(other.tag == 'Enemy')
        {
            // take damage boohoo 
        }
    }
}
