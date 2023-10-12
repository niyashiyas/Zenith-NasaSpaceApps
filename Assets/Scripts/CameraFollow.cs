using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform target; // The object the camera will follow
    public Vector3 offset = new Vector3(0f, 5f, -10f); // The offset from the target object

    void LateUpdate()
    {
        if (target != null)
        {
            // Update the camera's position based on the target object's position and offset
            transform.position = target.position + offset;

            // Make the camera look at the target object
            transform.LookAt(target.position);
        }
    }
}
