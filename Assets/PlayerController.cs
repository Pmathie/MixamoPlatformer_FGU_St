using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    public float moveSpeed = 5f;
    public float jumpHeight = 1.5f;
    public float Gravity = -20f;
    public Animator animator;

    private CharacterController controller;
    private Vector2 moveInput;
    private bool jumpQueued;
    private float verticalVelocity;

    private void Awake()
    {
        animator = GetComponent<Animator>();
        controller = GetComponent<CharacterController>();
    }
    public void OnMove(InputAction.CallbackContext context)
    {
         moveInput = context.ReadValue<Vector2>();
    }
    public void OnJump(InputAction.CallbackContext context)
    {
        if (context.started)
        {
            jumpQueued = true;
        }

    }
    // Update is called once per frame
    void Update()
    {
        bool isGrounded = controller.isGrounded;

        if(isGrounded && verticalVelocity < 0)
        {
            verticalVelocity = -2f;
        }
        if(jumpQueued && isGrounded)
        {
            verticalVelocity = Mathf.Sqrt(jumpHeight * -2f * Gravity);
            animator.SetTrigger("Jump");
        }
        jumpQueued = false;
        

        //Movement logic
        Vector3 MoveDirection = new Vector3(moveInput.x, 0, moveInput.y);
        Vector3 velocity = MoveDirection * moveSpeed;
        verticalVelocity += Gravity * Time.deltaTime;
        velocity.y = verticalVelocity;
        controller.Move(velocity * Time.deltaTime);

        //Rotation logic
        if (MoveDirection.magnitude > 0.1f)
        {
            Quaternion targetRotation = Quaternion.LookRotation(MoveDirection);
            transform.rotation = Quaternion.Slerp(transform.rotation, targetRotation, 10f * Time.deltaTime);
        }

        //Animation logic
        animator.SetFloat("Speed", MoveDirection.magnitude);
        animator.SetBool("Grounded", isGrounded);
        animator.SetFloat("VerticalVelocity", verticalVelocity);

    }
    
}
