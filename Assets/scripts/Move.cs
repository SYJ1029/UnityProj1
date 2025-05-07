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
        Cursor.lockState = CursorLockMode.Locked;  // 마우스 커서 고정

        rb.maxLinearVelocity = maxSpeed;
    }

    void FixedUpdate()
    {
        // 이동 계산
        if (Input.GetKeyDown(KeyCode.W))
        {
            accel = (Vector3.forward * moveForce);

        }
        if (Input.GetKeyDown(KeyCode.S))
        {
            accel = (Vector3.back * moveForce);

        }
        if (Input.GetKeyDown(KeyCode.A))
        {
            accel = (Vector3.left * moveForce);
        }
        if (Input.GetKeyDown(KeyCode.D))
        {
            accel = (Vector3.right * moveForce);
        }

        //if(Input.GetKeyUp(KeyCode.W | KeyCode.A | KeyCode.S | KeyCode.D))
        //{
        //    accel = Vector3.zero;
        //}
    }

    void Update()
    {
  

        float mouseX = Input.GetAxis("Mouse X") * mouseSensitivity;
        float mouseY = Input.GetAxis("Mouse Y") * mouseSensitivity;

        xRotation -= mouseY;
        xRotation = Mathf.Clamp(xRotation, -90f, 90f); // 위아래 각도 제한

        transform.localRotation = Quaternion.Euler(0f, transform.localEulerAngles.y + mouseX, 0f);
        Camera.main.transform.localRotation = Quaternion.Euler(xRotation, 0f, 0f);


        rb.AddForce(accel);


        // 마우스 회전


    }


}
