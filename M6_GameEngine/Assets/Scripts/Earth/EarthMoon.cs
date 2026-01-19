using UnityEngine;

public class EarthMoon : MonoBehaviour
{
    [SerializeField] GameObject earth;
    [SerializeField] GameObject moon;

    [SerializeField] int earthRotationSpeed = 1;
    [SerializeField] int gravityScale = 50;
    Vector3 VelocityMoon;
    Vector3 accelerationMoon;
    Vector3 diffrence;
    Vector3 direction;

    float distance;

    void Start()
    {
        VelocityMoon = new Vector3(1, 2, 3);
    }

    private void FixedUpdate()
    {
        earth.transform.Rotate(0, -earthRotationSpeed * Time.deltaTime, 0);

        diffrence = earth.transform.position - moon.transform.position;
        distance = diffrence.magnitude;
        direction = diffrence.normalized;

        //F = G * (m1 * m2) / r^2
        accelerationMoon = gravityScale * direction/(distance * distance);

        //Kinetic Loop
        VelocityMoon += accelerationMoon * Time.deltaTime;
        moon.transform.position += VelocityMoon * Time.deltaTime;
    }
}
