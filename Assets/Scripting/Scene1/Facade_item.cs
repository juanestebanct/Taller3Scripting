using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Facade_item : MonoBehaviour
{

    private Item1 item;
    private item2 item2;
    private item3 item3;
    private GameObject lastItem;
    int cambio = 1;

    private void Awake()
    {

        item = GetComponent<Item1>();
        item2 = GetComponent<item2>();
        item3 = GetComponent<item3>();

    }
    public GameObject GetItem()
    {
        if (lastItem != null)
        {
            Destroy(lastItem);
        }

        switch (cambio)
        {
            case 1:
                lastItem = item.CrearItem();
                cambio = 2;
                break;
            case 2:
                lastItem = item2.CrearItem();
                cambio = 3;
                break;
            case 3:
                lastItem = item3.CrearItem();
                cambio = 1;
                break;


        }
        lastItem.transform.position = transform.position;
        return gameObject;
    }
  
}
