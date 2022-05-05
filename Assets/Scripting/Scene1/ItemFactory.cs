using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class ItemFactory : MonoBehaviour,I_factory
{
    [SerializeField]
    private  GameObject itemTemp;

    public  GameObject CrearItem()
    {
        GameObject intance = Instantiate(itemTemp, new Vector3(0,0,0),transform.rotation); ;
        return intance;
    }
}
