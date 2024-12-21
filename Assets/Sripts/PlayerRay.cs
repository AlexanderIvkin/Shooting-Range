using UnityEngine;

public class PlayerRay : MonoBehaviour
{
    [SerializeField] private float _power;
    [SerializeField] private ParticleSystem _sparkParticles;

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

            if (Physics.Raycast(ray, out RaycastHit hit))
            {
                if (hit.collider.CompareTag("Target"))
                {
                    Rigidbody rigidbody = hit.collider.GetComponent<Rigidbody>();

                    if (rigidbody != null)
                    {
                        if(rigidbody.isKinematic == true)
                        {
                            rigidbody.isKinematic = false;
                        }

                        Vector3 forceDirection = hit.point - ray.origin;

                        rigidbody.AddForce(forceDirection.normalized * _power, ForceMode.Impulse);
                    }
                }
            }
        }
    }
}
