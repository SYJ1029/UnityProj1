using Unity.VisualScripting;
using UnityEngine;

public class Fire : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public GameObject bullet;
    float bulletSpeed = 20f;
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyUp(KeyCode.Return))
        {
            bullet.transform.position = transform.position;

            Rigidbody rb = bullet.GetComponent<Rigidbody>();
            rb.linearVelocity = transform.forward * bulletSpeed;
            rb.useGravity = false;
            bullet.SetActive(true);
        }
    }

   
}
