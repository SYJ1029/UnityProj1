using UnityEngine;

public class goBullet : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created

    float MaxTime = 30.0f;
    float decord_time = 0.0f;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(decord_time > MaxTime)
        {
            Destroy(gameObject);
        }

        decord_time += Time.deltaTime;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Enemy" || other.gameObject.tag == "Constructures")
        {
            Destroy(gameObject);
            if(other.gameObject.tag == "Enemy")
            {
                Destroy(other.gameObject);
            }
        }
    }

 
}
