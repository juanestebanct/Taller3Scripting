using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunController : MonoBehaviour
{
    //Punto de disparo de las balas:
    public Transform FirePoint;
    //Velocidad de la bala:
    [SerializeField] private float speed = 60.0f;

    
    //Prefabs de los 3 tipos de balas
    public GameObject TextBullet;
    public GameObject BlockBullet;
    public GameObject ParticleBullet; 

    private GameObject ActualBullet;
    

    private void Awake()
    {
        ActualBullet = TextBullet;
    }


    void Update()
    {
        BulletSelector();
    }

    private void BulletSelector() 
    {

        //Revisar que cambios hay que hacer al implementar los pools
        if (Input.GetButtonDown("Fire1"))
        {

            BulletMovement(ActualBullet);
            
        }
        else if (Input.GetButtonDown("Fire2"))
        {
            
            if (ActualBullet == TextBullet)
            {
                BlockBullet.SetActive(true);
                TextBullet.SetActive(false);
                ParticleBullet.SetActive(false);
                ActualBullet = BlockBullet;

            }
            else if (ActualBullet == BlockBullet)
            {
                BlockBullet.SetActive(false);
                TextBullet.SetActive(false);
                ParticleBullet.SetActive(true);
                ActualBullet = ParticleBullet;
            }
            else if (ActualBullet = ParticleBullet)
            {
                BlockBullet.SetActive(false);
                TextBullet.SetActive(true);
                ParticleBullet.SetActive(false);
                ActualBullet = TextBullet;
            }
            
        }

    }
    private void BulletMovement(GameObject bullet)
    {
        Vector3 bulletVelocity = Vector3.right * speed;                 //Set Bullet Direction
        bullet.transform.Translate(bulletVelocity * Time.deltaTime);   //Move Bullet based on Time
        //Rigidbody3D rb = bullet.GetComponent<Rigidbody3D>();
        //rb.AddForce(FirePoint.up * bulletForce, ForceMode3D.Impulse);

    }
}
