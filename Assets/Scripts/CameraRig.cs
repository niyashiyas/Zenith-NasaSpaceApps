using UnityEngine;

public class CameraRig : MonoBehaviour
{
    public Transform target;
    public float rotationSpeed = 1f;
    public Vector3 offset;

    void LateUpdate()
    {
        float horizontalInput = Input.GetAxis("Horizontal") * rotationSpeed;
        target.Rotate(0, horizontalInput, 0);

        float desiredAngle = target.eulerAngles.y;
        Quaternion rotation = Quaternion.Euler(0, desiredAngle, 0);
        transform.position = target.position - (rotation * offset);
        transform.LookAt(target);
    }
}
