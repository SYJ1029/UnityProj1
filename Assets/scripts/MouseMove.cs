using UnityEngine;

public class MouseMove : MonoBehaviour
{
    CharacterController characterController;

    public float mouseSensitivity;

    float xRotation = 0f;
    float yRotation = 0f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
        characterController = GetComponent<CharacterController>();
    }

    // Update is called once per frame
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
        characterController.transform.rotation = Quaternion.Euler(0f, yRotation, 0f);
        //transform.rotation = Quaternion.Euler(0f, yRotation, 0f);

        characterController.Move(Vector3.zero);
    }
}
