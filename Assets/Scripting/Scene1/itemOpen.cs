using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class itemOpen : MonoBehaviour
{
    private Facade_item faccade;

    private void Awake()
    {
        faccade = GetComponent<Facade_item>();
    }

    public void onclick()
    {
        faccade.GetItem();
    }
}
