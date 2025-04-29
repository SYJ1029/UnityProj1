using UnityEngine;

public class tranform : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public GameObject playerobject;

    void Awake()
    {

    }
   
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = playerobject.transform.position;
        transform.rotation = playerobject.transform.rotation * Quaternion.Euler(0.0f, 1.0f, 0.0f);
    }
}
