using UnityEngine;
using UnityEngine.InputSystem;


public class PlayerInputDemo : MonoBehaviour
{
    public float moveSpeed = 5f;

    private Vector2 moveInput;

    public void OnMove(InputAction.CallbackContext context)
    {
        moveInput = context.ReadValue<Vector2>();
    }

    public void OnJump(InputAction.CallbackContext context)
    {
        if (!context.performed) return;
        transform.Rotate(0f, 0f, 90f);
    }

    void Update()
    {
        transform.position +=
         (Vector3)(moveInput * moveSpeed * Time.deltaTime);
    }

}

