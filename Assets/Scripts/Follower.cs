using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using PathCreation;

public class Follower : MonoBehaviour
{
    public PathCreator pathCreator;
    public float speed = 1;
    float distanceTravelled;

    // Update is called once per frame
    void Update()
    {
        // Calculate the total length of the path
        float pathLength = pathCreator.path.length - 0.1f;

        // Check if the distance traveled is less than the total length of the path
        if (distanceTravelled <= pathLength)
        {
            // Update the distance travelled
            distanceTravelled += speed * Time.deltaTime;

            // Get the position on the path at the current distance travelled
            Vector3 newPosition = pathCreator.path.GetPointAtDistance(distanceTravelled);

            // Set the position of the object
            transform.position = newPosition;
        }
    }
}
