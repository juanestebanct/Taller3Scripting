using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class View : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Colorcubo.Instance.OnButtonClicked += mensaje;
    }

   void mensaje(int count)
    {
        Debug.Log($"el ciclo de color va en {count}");
    }
}
