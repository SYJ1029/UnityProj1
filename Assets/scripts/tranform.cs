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
    
    }


    private void OnTriggerEnter(Collider other)
    {
        Destroy(gameObject);

    }
}
