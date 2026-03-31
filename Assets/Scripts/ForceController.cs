using UnityEngine;

public class ForceController : MonoBehaviour
{
    public float accel;
    Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    public void CalculateAndApplyForce()
    {
        float mass = rb.mass;
        float force = mass * accel;
        rb.AddForce(new Vector3(0, 0, force));
        Debug.Log($"Mass {mass} kg with accel {accel} m/s^2 = {force} N");
    }
    public void SetAccel200()
    {
        accel = 200f;
        CalculateAndApplyForce();
    }

    public void SetAccel500()
    {
        accel = 500f;
        CalculateAndApplyForce();
    }

    public void SetAccel1000()
    {
        accel = 1000f;
        CalculateAndApplyForce();
    }
}