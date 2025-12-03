using UnityEngine;

public class ExplosiveRigidbody : MonoBehaviour, IExplodable
{
    public void OnExplode(Vector3 explosionPosition, float explosionForce)
    {
        Rigidbody rigidbody = GetComponent<Rigidbody>();
        if (rigidbody != null)
        {
            Vector3 direction = transform.position - explosionPosition;
            rigidbody.AddForce(direction.normalized * explosionForce);
        }
    }
}
