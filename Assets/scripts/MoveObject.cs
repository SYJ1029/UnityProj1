using UnityEngine;

public class MoveObject : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created

    public float multipler = 3;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(transform.forward * multipler);
    }
}
