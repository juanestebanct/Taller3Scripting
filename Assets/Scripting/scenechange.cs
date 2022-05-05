using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class scenechange: MonoBehaviour
{
    // Start is called before the first frame update
    public void Punto1() {

        SceneManager.LoadScene("punto1");
    }
    public void Punto2()
    {

        SceneManager.LoadScene("punto2");
    }
    public void Punto3()
    {

        SceneManager.LoadScene("punto3");
    }
    public void main()
    {

        SceneManager.LoadScene("Inicio");
    }
}
