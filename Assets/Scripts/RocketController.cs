using UnityEngine;

public class RocketController : MonoBehaviour
{
    public Transform target; // The target object to move towards
    public float moveSpeed = 5f; // The speed at which the object moves towards the target

    void Update()
    {
        if (target != null)
        {
            // Calculate the direction from the object to the target
            Vector3 directionToTarget = (target.position - transform.position).normalized;

            // Move the object in the calculated direction
            transform.Translate(directionToTarget * moveSpeed * Time.deltaTime);
        }
        else
        {
            Debug.LogError("Target is not assigned!");
        }
    }
}
