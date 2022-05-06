using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunController : MonoBehaviour
{
    //Punto de disparo de las balas:
    public Transform FirePoint;
    //Velocidad de la bala:
    [SerializeField] private float speed = 30.0f;

    //Prefabs de los 3 tipos de balas
    public GameObject TextBullet;
    public GameObject BlockBullet;
    public GameObject ParticleBullet;

    private GameObject ActualBullet;

    //Referencias a los pools
    private BlockBulletPool blockBulletPool = new BlockBulletPool();
    private ParticleBulletPool particleBulletPool = new ParticleBulletPool();
    private TextBulletPool textBulletPool = new TextBulletPool();

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
        if (Input.GetMouseButtonDown(0))
        {
            BulletMovement(ActualBullet);
        }
        else if (Input.GetMouseButtonDown(1))
        {
            if (ActualBullet == TextBullet)
            {
                ActualBullet = BlockBullet;
            }
            else if (ActualBullet == BlockBullet)
            {
                ActualBullet = ParticleBullet;
            }
            else if (ActualBullet = ParticleBullet)
            {
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
