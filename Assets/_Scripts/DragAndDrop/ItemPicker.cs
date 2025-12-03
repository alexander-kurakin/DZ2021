using UnityEngine;

public class ItemPicker
{
    private IMovable _pickedItem;

    public IMovable PickupItem(Vector3 origin, Vector3 direction)
    {
        Ray ray = new Ray(origin, direction);

        if (Physics.Raycast(ray, out RaycastHit hit))
        {
            _pickedItem = hit.collider.GetComponent<IMovable>();

            if (_pickedItem != null)
                _pickedItem.Grab();
        }

        return _pickedItem;
    }

    public void DropItem(IMovable itemToDrop)
    {
        if (itemToDrop != null)
            itemToDrop.Drop();
    }   
}
