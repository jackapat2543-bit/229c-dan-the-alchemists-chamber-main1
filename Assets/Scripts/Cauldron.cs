using UnityEngine;

public class Cauldron : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Potions"))
        {
            // เปลี่ยนสีหม้อ
            GetComponent<Renderer>().material.color = Color.green;

            Rigidbody rb = other.GetComponent<Rigidbody>();

            if (rb != null)
            {
                rb.velocity = Vector3.zero;
                rb.angularVelocity = Vector3.zero;
            }
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Obstacle"))
        {
            GetComponent<Renderer>().material.color = Color.red;

            Rigidbody rb = GetComponent<Rigidbody>();
            if (rb != null)
            {
                rb.AddTorque(Vector3.up * 50f);
            }
        }
    }
}