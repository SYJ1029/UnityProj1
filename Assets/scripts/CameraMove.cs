using UnityEngine;

public class exsc : MonoBehaviour
{
    public GameObject player;
    public float mouseSensitivity = 3.0f;

    private float xRotation = 0f;

    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked; // ���콺 Ŀ�� ����
    }

    void Update()
    {
        transform.rotation = Quaternion.LookRotation(player.transform.forward);
    }
}