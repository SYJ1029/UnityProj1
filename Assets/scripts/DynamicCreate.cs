using Unity.VisualScripting;
using UnityEngine;

public class DynamicCreate : MonoBehaviour
{
    public GameObject[] newobject = new GameObject[3];
    public float interval = 5.0f;           // 积己 林扁
    public float spawnDistance = 5.0f;      // 积己 芭府

    private float timer = 0f;

    void Update()
    {
        timer += Time.deltaTime;

        if (timer >= interval)
        {
            timer = 0f;

            Vector3 spawnPosition = transform.position + transform.forward * spawnDistance;

            GameObject obj = Instantiate(newobject[0], spawnPosition, Quaternion.identity);
        }
    }
}