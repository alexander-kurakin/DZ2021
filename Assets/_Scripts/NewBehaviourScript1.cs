using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class ItemInteractor 
{
    private Transform _grabPoint;




    public void Interact()
    {
        PickupItem();
    }

    private void PickupItem()
    {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

        if (Physics.Raycast(ray, out RaycastHit hit))
        {

        }
    }

    private void DropItem()
    {

    }   
}
