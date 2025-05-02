using UnityEngine;

public class FindGravity : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // ��� Rigidbody ������Ʈ�� ã�ƿ�
        Rigidbody[] allRigidbodies = FindObjectsOfType<Rigidbody>();

        foreach (Rigidbody rb in allRigidbodies)
        {
            if (rb.useGravity)
            {
                Debug.Log($"Gravity ���� ���� ������Ʈ: {rb.gameObject.name}");
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
