using UnityEngine;
using System.Collections;

public class Move : MonoBehaviour
{
    float degree = 0.0f;
    Rigidbody rb;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            rb.AddForce(new Vector3(0.0f, 0.0f, 3.0f));
        }

        if (Input.GetKey(KeyCode.S))
        {
            rb.AddForce(new Vector3(0.0f, 0.0f, -3.0f));
        }

        if (Input.GetKey(KeyCode.A))
        {
            rb.AddForce(new Vector3(-3.0f, 0.0f, 0.0f));
        }

        if (Input.GetKey(KeyCode.D))
        {
            rb.AddForce(new Vector3(3.0f, 0.0f, 0.0f));
            //transform.Rotate(new Vector3(1.0f, 0.0f, 0.0f));
    
        }

    }
}
