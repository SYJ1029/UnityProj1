using UnityEngine;
using static UnityEngine.ParticleSystem;

public class PickingFire : MonoBehaviour
{
    public GameObject particle;
    Transform pickedtransform;
    Camera camera;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        camera = GetComponent<Camera>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButton(0))
        {
            Ray ray = camera.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;
            if (Physics.Raycast(ray, out hit, 1000))
            {
          
                Instantiate(particle, hit.transform.position, hit.transform.rotation);
            }

        }

    }

}
