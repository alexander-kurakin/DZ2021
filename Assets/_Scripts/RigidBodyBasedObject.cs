using UnityEngine;

public class RigidBodyBasedObject : MonoBehaviour, IMovable
{
    private Rigidbody _rigidbody;

    private void Awake()
    {
        _rigidbody = GetComponent<Rigidbody>();
    }

    public void Grab()
    {
        _rigidbody.isKinematic = true;
    }

    public void Drag(Vector3 movePoint)
    {
        _rigidbody.MovePosition(movePoint);
    }

    public void Drop(IMovable itemToDrop)
    {
        _rigidbody.isKinematic = false;
    }
}
