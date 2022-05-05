using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Touch : MonoBehaviour
{
    private void Update()
    {
        if (Input.GetMouseButtonDown(1))
        {
            Colorcubo.Instance.Notify();
        }
       //     Colorcubo.Instance.OnButtonClicked();
    }
}
