using UnityEngine;

public class exsc : MonoBehaviour
{
    public GameObject player;
    public float mouseSensitivity = 3.0f;

    private float xRotation = 0f;

    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked; // 마우스 커서 고정
    }

    void Update()
    {
        transform.rotation = Quaternion.LookRotation(player.transform.forward);
    }
}