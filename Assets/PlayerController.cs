using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    public float moveSpeed = 5f;
    public float jumpHeight = 1.5f;
    public float Gravity = -20f;
    public Animator animator;

    private Vector2 moveInput;
    private bool jumpQueued;
    private float verticalVelocity;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void OnMove(InputAction.CallbackContext context)
    {
        Debug.Log("Move: " + context.ReadValue<Vector2>());
    }
    public void OnJump(InputAction.CallbackContext context)
    {
        if (context.started)
        {
            Debug.Log("Jump");
        }
        
    }
}
