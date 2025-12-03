using UnityEngine;

public class Explosion : IShootEffect
{
    private float _explosionRadius;
    private float _explosionForce;

    public Explosion(float explosionRadius, float explosionForce) 
    { 
        _explosionRadius = explosionRadius;
        _explosionForce = explosionForce;
    }
    
    public void ProcessEffect(Vector3 shootPosition)
    {
        Collider[] targets = Physics.OverlapSphere(shootPosition, _explosionRadius);

        foreach (Collider target in targets)
        {
            if (target.TryGetComponent<IExplodable>(out IExplodable explodable))
            {
                explodable.OnExplode(shootPosition, _explosionForce);
            }
        }
    }
}
