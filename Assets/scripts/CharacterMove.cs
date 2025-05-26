using UnityEngine;

public class CharacterMove : MonoBehaviour
{
    float degree = 0.0f;
    CharacterController controller;
    KeyCode prevKey;

    public float moveForce;
    public float mouseSensitivity;
    public float jumpForce;
    float jumpSpeed;

    public float maxSpeed;
    private Vector3 accel = Vector3.zero;

    float xRotation = 0f;
    float yRotation = 0f;

    void Start()
    {
        controller = GetComponent<CharacterController>();
        Cursor.lockState = CursorLockMode.Locked;

        jumpSpeed = jumpForce;
    }

    void FixedUpdate()
    {
        
    }

    void Update()
    {

        float mouseX = Input.GetAxisRaw("Mouse X");
        float mouseY = Input.GetAxisRaw("Mouse Y");

        // Deadzone 적용
        if (Mathf.Abs(mouseX) < 0.01f) mouseX = 0f;
        if (Mathf.Abs(mouseY) < 0.01f) mouseY = 0f;

        // 민감도 적용 + 프레임 보정
        mouseX *= mouseSensitivity * Time.deltaTime;
        mouseY *= mouseSensitivity * Time.deltaTime;

        // 누적
        yRotation += mouseX;
        xRotation -= mouseY;
        xRotation = Mathf.Clamp(xRotation, -90f, 90f);

        // 상하 회전: 카메라에만
        Camera.main.transform.localRotation = Quaternion.Euler(xRotation, 0f, 0f);

        // 좌우 회전: 플레이어 바디에만
        transform.rotation = Quaternion.Euler(0f, yRotation, 0f);



        if (Input.GetKey(KeyCode.W))
        {
            accel += (Vector3.forward * moveForce);

        }
        if (Input.GetKey(KeyCode.S))
        {
            accel += (Vector3.back * moveForce);

        }
        if (Input.GetKey(KeyCode.A))
        {
            accel += (Vector3.left * moveForce);
        }
        if (Input.GetKey(KeyCode.D))
        {
            accel += (Vector3.right * moveForce);
        }


       
        if (Input.GetKeyDown(KeyCode.Space))
        {
            jumpSpeed = jumpForce;
        }

        if(jumpSpeed > 0.0f)
        {
            accel += Vector3.up * jumpSpeed;
            jumpSpeed += Physics.gravity.y * 0.5f;
        }

        if (Input.GetKeyUp(KeyCode.W) || Input.GetKeyUp(KeyCode.S) || Input.GetKeyUp(KeyCode.A) || Input.GetKeyUp(KeyCode.D))
        {
            accel = Vector3.zero;
        }

        if(Physics.Raycast(transform.position, Vector3.down, 0.1f))
        {
            print("바닥에 닿아있어요");
        }
        else
        {
            accel += Physics.gravity;
        }


            controller.Move(accel * Time.deltaTime);


        accel = Vector3.zero;

       
    }
}
