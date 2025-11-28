using UnityEngine;

public class ExplosionShooter : MonoBehaviour
{
    private const float ExplosionRadius = 5f;
    private const float ExplosionForce = 750f;

    [SerializeField] private ParticleSystem _explosionEffect;
    public void Shoot(Vector3 shootPosition)
    {
        Instantiate(_explosionEffect, shootPosition, Quaternion.identity);
        
        Collider[] targets = Physics.OverlapSphere(shootPosition, ExplosionRadius);

        foreach(Collider target in targets)
        {
            Rigidbody rb = target.GetComponent<Rigidbody>();
            if (rb != null)
            {
                Vector3 direction = target.transform.position - shootPosition;
                rb.AddForce(direction.normalized * ExplosionForce);
            }
        }
    }
}