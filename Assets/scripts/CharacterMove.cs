using UnityEngine;
using UnityEngine.InputSystem;

public class CharacterMove : MonoBehaviour
{
    float degree = 0.0f;
    CharacterController controller;
    KeyCode prevKey;

    public float moveForce;
    public float maxSpeed;

    public float jumpForce;
    float jumpSpeed;
    private Vector3 accel = Vector3.zero;



    void Start()
    {
        controller = GetComponent<CharacterController>();

        jumpSpeed = 0f;
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


       
        if (Input.GetKeyDown(KeyCode.Space) && controller.transform.position.y <= accel.y)
        {
            jumpSpeed = jumpForce;
        }

        if(jumpSpeed > 0.0f)
        {
            accel += Vector3.up * jumpSpeed;
            jumpSpeed += Physics.gravity.y * 0.5f;
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
