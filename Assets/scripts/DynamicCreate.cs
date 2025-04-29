using Unity.VisualScripting;
using UnityEngine;

public class DynamicCreate : MonoBehaviour
{

    public GameObject newobject;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        GameObject object0 = Instantiate(newobject, new Vector3(2.0f, 1.0f, 0.0f), Quaternion.identity);
        Destroy(object0, 1.0f);
    }
}
