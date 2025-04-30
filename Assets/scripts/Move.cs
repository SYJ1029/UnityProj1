using UnityEngine;
using System.Collections;


public class Move : MonoBehaviour
{
    float degree = 0.0f;
    Rigidbody rb;

    public float moveForce = 3.0f;
    public float mouseSensitivity = 3.0f;

    float xRotation = 0f;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        Cursor.lockState = CursorLockMode.Locked;  // 마우스 커서 고정
    }

    void Update()
    {
        // 이동
        if (Input.GetKey(KeyCode.W))
        {
            rb.AddForce(Vector3.forward * moveForce);
        }
        if (Input.GetKey(KeyCode.S))
        {
            rb.AddForce(Vector3.back * moveForce);
        }
        if (Input.GetKey(KeyCode.A))
        {
            rb.AddForce(Vector3.left * moveForce);
        }
        if (Input.GetKey(KeyCode.D))
        {
            rb.AddForce(Vector3.right * moveForce);
        }

        // 마우스 회전
        float mouseX = Input.GetAxis("Mouse X") * mouseSensitivity;
        float mouseY = Input.GetAxis("Mouse Y") * mouseSensitivity;

        xRotation -= mouseY;
        xRotation = Mathf.Clamp(xRotation, -90f, 90f); // 위아래 각도 제한

        transform.localRotation = Quaternion.Euler(0f, transform.localEulerAngles.y + mouseX, 0f);
        Camera.main.transform.localRotation = Quaternion.Euler(xRotation, 0f, 0f);
    }
}
