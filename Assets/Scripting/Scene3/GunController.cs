using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunController : MonoBehaviour
{
    //Punto de disparo de las balas:
    public Transform FirePoint;
    
    //Prefabs de los 3 tipos de balas
    public GameObject TextBullet;
    public GameObject BlockBullet;
    public GameObject ParticleBullet;

    //Referencias a los pools
    private BlockBulletPool blockBulletPool = new BlockBulletPool();
    private ParticleBulletPool particleBulletPool = new ParticleBulletPool();
    private TextBulletPool textBulletPool = new TextBulletPool();


    // Update is called once per frame
    void Update()
    {
        
    }

    private void BulletSelector()
    {
        if (Input.GetMouseButtonDown(0))
        {
            
        }
        else if (Input.GetMouseButtonDown(1))
        {
            
        }

    }
}
