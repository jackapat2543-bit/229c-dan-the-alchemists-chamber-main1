using UnityEngine;

public class AddForce : MonoBehaviour
{
    public float force;
    public float mass;
    public float accel;

    void CalculateForce()
    {
        mass = GetComponent<Rigidbody>().mass;
        force = mass * accel;
        GetComponent<Rigidbody>().AddForce(force, force, 0);
    }

    public void SetAccel200()
    {
        accel = 200f;
        CalculateForce();
    }

    public void SetAccel500()
    {
        accel = 500f;
        CalculateForce();
    }

    public void SetAccel1000()
    {
        accel = 1000f;
        CalculateForce();
    }
}