using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class observador : MonoBehaviour
{


    private Renderer cubo ;
    void Start()
    {

       cubo= gameObject.GetComponent<Renderer>();
        Colorcubo.Instance.OnButtonClicked+= aplicarcolor;
    }
    private void aplicarcolor(int contador)
    {
     
        chaceColor(contador);
        Debug.Log($"el ciclo de color va en {contador}");
    }
    private void chaceColor(int contador)
    {
        switch (contador)
        {
            case 1:
                cubo.material.color = Color.white;
                break;
            case 2:
                cubo.material.color = Color.black;
                break;
            case 3:
                cubo.material.color = Color.yellow;
                break;

            case 4:
                cubo.material.color = Color.green;
       
                break;



        }
    }
}
