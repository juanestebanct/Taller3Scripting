using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    //nolaestoypasandobienauxilio

    [SerializeField] private float autoDestroyTime;
    //Velocidad de la bala:
    [SerializeField] private float speed = 30.0f;

    private Rigidbody rb;

    public Rigidbody Rb
    {
        get
        {
            if (rb==null)
            {
                rb = GetComponent<Rigidbody>();
            }

            return rb;
        }
    }


    // Update is called once per frame
    void Update()
    {
        
    }

    private void BulletMovement(GameObject bullet)
    {
        Vector3 bulletVelocity = Vector3.right * speed;                 //Set Bullet Direction
        bullet.transform.Translate(bulletVelocity * Time.deltaTime);   //Move Bullet based on Time
        //Rigidbody3D rb = bullet.GetComponent<Rigidbody3D>();
        //rb.AddForce(FirePoint.up * bulletForce, ForceMode3D.Impulse);

    }
    internal virtual void CollisionEffects()
    {


        
    }

    public void OnBulletGot()
    {
        Invoke("DisableBullet", autoDestroyTime);
    }

    protected virtual void DisableBullet()
    {
        
    }
}
