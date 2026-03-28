using UnityEngine;

public class PotionRaycast : MonoBehaviour
{
    [SerializeField] private Transform shootPos;
    [SerializeField] private float rayLength = 10f;

    void Update()
    {
        // วาดเส้น Ray
        Debug.DrawRay(shootPos.position, -transform.forward * rayLength, Color.green);

        // คลิกเมาส์ขวา
        if (Input.GetMouseButtonDown(1))
        {
            RaycastHit hit;

            if (Physics.Raycast(shootPos.position, transform.forward, out hit, rayLength))
            {
                Debug.Log("Selected Potion: " + hit.collider.name);

                if (hit.collider.CompareTag("Potions"))
                {
                    Renderer rend = hit.collider.GetComponent<Renderer>();
                    if (rend != null)
                    {
                        rend.material.color = Color.yellow;
                    }
                }
            }
        }
    }
}