using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.PlayerLoop;

public class Fire : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public GameObject bulletPrefab;
    public Transform firePoint;   
    public float bulletSpeed = 20f;
    float elapsedTimes = 0.0f;
    public float timeInterval = 0.5f; 
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButton(0))
        {
            if (elapsedTimes >= timeInterval)
            {
                GameObject bullet = Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);

                Rigidbody rb = bullet.GetComponent<Rigidbody>();
                rb.linearVelocity = transform.forward * bulletSpeed;
                rb.useGravity = false;
                elapsedTimes = 0.0f;
            }
            
            
        }

        elapsedTimes += Time.deltaTime;

    }


}
