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

        
    }
    
}
