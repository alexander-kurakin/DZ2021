using UnityEngine;

public interface IMovable
{
    public void Grab();
    public void Drag(Vector3 movePoint);
    public void Drop();
}
