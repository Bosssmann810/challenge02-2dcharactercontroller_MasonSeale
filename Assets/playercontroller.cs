using UnityEngine;
using UnityEngine.InputSystem;

public class playercontroller : MonoBehaviour
{
    private Rigidbody2D rb;
    public Vector2 moveInput;
    public float movespeed;
    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }
    public void OnMove(InputAction.CallbackContext context)
    {
        moveInput = context.ReadValue<Vector2>();


    }
    private void FixedUpdate()
    {
        handleplayermovement();
        
    }
    public void handleplayermovement()
    {
        rb.MovePosition(rb.position + moveInput * movespeed * Time.fixedDeltaTime);
    }
}
