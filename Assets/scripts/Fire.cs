using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.PlayerLoop;

public class Fire : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public GameObject bulletPrefab;
    public Transform firePoint;   
    float bulletSpeed = 20f;
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyUp(KeyCode.Space))
        {
            GameObject bullet = Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);

            Rigidbody rb = bullet.GetComponent<Rigidbody>();
            rb.linearVelocity = transform.forward * bulletSpeed;
            rb.useGravity = false;
        }
    }

   
}
