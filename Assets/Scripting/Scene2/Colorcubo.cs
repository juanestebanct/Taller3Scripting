using System.Collections;
using UnityEngine;
using System;

public class Colorcubo : MonoBehaviour
{

    public static Colorcubo Instance;
    private int estadocolor;
    public event Action<int> OnButtonClicked;
    private int contador = 1;

    public void Awake()
    {
       
        if (Instance != null)
            Destroy(gameObject);
        else
            Instance = this;
    }
    public void Notify()
    {
        if (OnButtonClicked != null)
        {
            OnButtonClicked(contador);
            contador++;
            if (contador >4)
                contador = 1;
        }

    }

}
