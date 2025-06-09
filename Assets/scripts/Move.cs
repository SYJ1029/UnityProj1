using UnityEngine;
using System.Collections;


public class Move : MonoBehaviour
{
    float degree = 0.0f;
    Rigidbody rb;
    KeyCode prevKey;

    public float moveForce;
    public float mouseSensitivity;

    public float maxSpeed;
    private Vector3 accel = Vector3.zero;

    float xRotation = 0f;

    void Start()
    {
        rb = GetComponent<Rigidbody>();

    }

    void FixedUpdate()
    {
       
    }

    void Update()
    {

        // 이동 계산
        if (Input.GetKey(KeyCode.W))
        {
            accel += (transform.forward * moveForce);

        }
        if (Input.GetKey(KeyCode.S))
        {
            accel += (transform.forward * -1 * moveForce);

        }
        if (Input.GetKey(KeyCode.A))
        {
            accel += (transform.right * -1 * moveForce);
        }
        if (Input.GetKey(KeyCode.D))
        {
            accel += (transform.right * moveForce);
        }

        if (Input.GetKeyUp(KeyCode.W) || Input.GetKeyUp(KeyCode.S) || Input.GetKeyUp(KeyCode.A) || Input.GetKeyUp(KeyCode.D))
        {
            accel = Vector3.zero;
        }
        float mouseX = Input.GetAxis("Mouse X") * mouseSensitivity;
        float mouseY = Input.GetAxis("Mouse Y") * mouseSensitivity;

        xRotation -= mouseY;
        xRotation = Mathf.Clamp(xRotation, -90f, 90f); // 위아래 각도 제한

        transform.localRotation = Quaternion.Euler(0f, transform.localEulerAngles.y + mouseX, 0f);
        Camera.main.transform.localRotation = Quaternion.Euler(xRotation, 0f, 0f);


        rb.AddForce(accel);

        accel = Vector3.zero;


    }


}
