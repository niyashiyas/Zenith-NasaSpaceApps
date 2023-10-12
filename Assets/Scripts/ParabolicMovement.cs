using UnityEngine;

public class ParabolicMovement : MonoBehaviour
{
    public Vector3 startPoint = new Vector3(2.20405531f, -0.398319602f, 0.0855052546f);
    public Transform mars;
    public Transform player; // Reference to the player object
    public float height = 2f; // Adjust this to control the height of the parabolic path
    public float duration = 3f; // Duration of the initial movement
    public float acceleration = 0.3f; // Acceleration after 1 second
    public float landingThreshold = 1f; // Y position threshold for landing

    private float startTime;
    private bool isMoving = true;

    void Start()
    {
        startTime = Time.time;
    }

    void Update()
    {
        if (isMoving)
        {
            float t = (Time.time - startTime) / duration;

            // If the initial movement duration is not over, follow the parabolic path
            if (t <= 2.5f)
            {
                float parabolicT = Mathf.Sin(t * Mathf.PI * 0.5f); // Applying a sinusoidal function for a smooth parabolic path
                transform.position = Vector3.Lerp(startPoint, mars.position, t) + Vector3.up * parabolicT * height;
            }
            else
            {
                transform.position = Vector3.Lerp(startPoint, mars.position, t);

                // Check if the Y positions are close enough for landing
                if (Mathf.Abs(transform.position.y - player.position.y - 20) <= landingThreshold || transform.position.z > 22f)
                {
                    // Land on the player
                    transform.position = new Vector3(transform.position.x, player.position.y , transform.position.z);
                    isMoving = false;
                }
            }
        }
    }

    void OnCollisionEnter(Collision collision)
    {
        // Check if the object collides with the Mars object
        if (collision.gameObject.CompareTag("Player"))
        {
            isMoving = false;

        }
    }
}
