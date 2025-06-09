using Unity.VisualScripting.InputSystem;
using UnityEngine;
using UnityEngine.InputSystem;

public class CharacterMove : MonoBehaviour
{
    float degree = 0.0f;
    CharacterController controller;

    public float moveForce;
    public float maxSpeed;

    private Vector3 accel = Vector3.zero;



    void Start()
    {
        controller = GetComponent<CharacterController>();

    }

    void FixedUpdate()
    {
        
    }

    void Update()
    {


        if (Input.GetKey(KeyCode.W))
        {
            accel += (Vector3.forward * moveForce);

        }
        if (Input.GetKey(KeyCode.S))
        {
            accel += (Vector3.back * moveForce);

        }
        if (Input.GetKey(KeyCode.A))
        {
            accel += (Vector3.left * moveForce);
        }
        if (Input.GetKey(KeyCode.D))
        {
            accel += (Vector3.right * moveForce);
        }

       
       
        if (Input.GetKeyUp(KeyCode.W) || Input.GetKeyUp(KeyCode.S) || Input.GetKeyUp(KeyCode.A) || Input.GetKeyUp(KeyCode.D))
        {
            accel = Vector3.zero;
        }

        if(Physics.Raycast(transform.position, Vector3.down, 0.1f))
        {
            print("¹Ù´Ú¿¡ ´ê¾ÆÀÖ¾î¿ä");
        }
        else
        {
            accel += Physics.gravity;
        }


        controller.Move(accel * Time.deltaTime);


        accel = Vector3.zero;

       
    }
}
