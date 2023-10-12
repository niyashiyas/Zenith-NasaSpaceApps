using UnityEngine;

public class CameraController : MonoBehaviour
{
    // Speed at which the camera moves
    public float moveSpeed = 5f;

    // Boolean to determine if camera movement is allowed
    private bool canMove = false;

    void Update()
    {
        // Toggle camera movement when the 'W' key is pressed
        if (Input.GetKeyDown(KeyCode.Q))
        {
            canMove = !canMove;
        }

        // Move the camera when allowed
        if (canMove)
        {
            float horizontalInput = Input.GetAxis("Horizontal");
            float verticalInput = Input.GetAxis("Vertical");

            // Calculate new position based on input and move speed
            Vector3 moveDirection = new Vector3(horizontalInput, 0f, verticalInput).normalized;
            Vector3 moveAmount = moveDirection * moveSpeed * Time.deltaTime;
            transform.Translate(moveAmount);
        }
    }
}
