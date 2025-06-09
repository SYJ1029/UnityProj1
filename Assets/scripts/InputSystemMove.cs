using Unity.VisualScripting.InputSystem;
using UnityEngine;
using UnityEngine.InputSystem;

public class InputSystemMove : MonoBehaviour
{

    CharacterController controller;

    public float moveForce;
    public float maxSpeed;

    public float jumpForce;
    float jumpSpeed;

    Vector2 movevalue;

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
        Vector3 movevector = new Vector3(movevalue.x, 0, movevalue.y);

        accel += movevector * moveForce;
        accel += Physics.gravity;

        controller.Move(accel * Time.deltaTime);

        accel = Vector3.zero;
    }

    public void OnMove(InputAction.CallbackContext context)
    {
        movevalue = context.ReadValue<Vector2>();

        if (movevalue == Vector2.zero)
            return;

       
        print(movevalue);
    }

    public void OnJump()
    {
        print("JUMP");
    }
}
