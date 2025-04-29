using UnityEngine;

public class ChangeLight : MonoBehaviour
{
    Light light;
    int count = 0;
    float t = 0.0f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        light = GetComponent<Light>();
    }

    // Update is called once per frame
    void Update()
    {

        t += Time.deltaTime;
        if (t > 3.0f)
        {
            light.color = Random.ColorHSV(0f, 1f, 1f, 1f, 0.5f, 1f);
            t = 0.0f;
        }
        ++count;
    }
}
