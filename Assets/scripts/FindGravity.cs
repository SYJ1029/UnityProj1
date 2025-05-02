using UnityEngine;

public class FindGravity : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // 모든 Rigidbody 컴포넌트를 찾아옴
        Rigidbody[] allRigidbodies = FindObjectsOfType<Rigidbody>();

        foreach (Rigidbody rb in allRigidbodies)
        {
            if (rb.useGravity)
            {
                Debug.Log($"Gravity 적용 중인 오브젝트: {rb.gameObject.name}");
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
