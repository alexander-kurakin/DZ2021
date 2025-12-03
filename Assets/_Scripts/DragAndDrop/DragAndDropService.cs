using UnityEngine;

public class DragAndDropService : MonoBehaviour
{
    private ItemPicker _itemPicker;
    private IMovable _currentItem;

    private void Awake()
    {
        _itemPicker = new ItemPicker();
    }

    public IMovable TryPickUpItem(Vector3 origin, Vector3 direction)
    {
        _currentItem = _itemPicker.PickupItem(origin, direction);
        return _currentItem;
    }

    public void TryDragItem(Vector3 dragPosition)
    { 
        _currentItem.Drag(dragPosition);
    }

    public void TryDropItem()
    {
        if (_currentItem != null)
        {
            _itemPicker.DropItem(_currentItem);
            _currentItem = null;
        }
    }
}
