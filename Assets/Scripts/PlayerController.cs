using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Rigidbody rb;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }


    void Update() { 
        Vector3 vel = rb.velocity;
        if (Input.GetKey(KeyCode.RightArrow))
            rb.velocity = new Vector3(3f, vel.y, vel.z);
        if (Input.GetKey(KeyCode.LeftArrow))
            rb.velocity = new Vector3(-3f, vel.y, vel.z);
        if (Input.GetKeyDown(KeyCode.Space))
            rb.velocity = new Vector3(vel.x, 5f, vel.z);
    }
}
