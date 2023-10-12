using UnityEngine;
public class SpaceshipRoundTrip : MonoBehaviour
{
    public Transform earth;
    public Transform mars;
    public float speed = 5.0f;
    private bool goingToMars = true;
    void Update()
    {
        // Determine the target planet based on the current direction
        Transform targetPlanet = goingToMars ? mars : earth;

        // Move the spaceship towards the target planet
        MoveTowardsPlanet(targetPlanet);

        // Check if the spaceship has reached the target planet
        if (Vector3.Distance(transform.position, targetPlanet.position) < 0.1f)
        {
            // Switch direction (Earth to Mars or Mars to Earth)
            goingToMars = !goingToMars;
        }
    }
    void MoveTowardsPlanet(Transform targetPlanet)
    {
        // Calculate the direction to the target planet
        Vector3 direction = (targetPlanet.position - transform.position).normalized;

        // Move the spaceship in the calculated direction
        transform.Translate(direction * speed * Time.deltaTime);
    }
}