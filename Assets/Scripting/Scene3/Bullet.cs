using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    //nolaestoypasandobienauxilio

    [SerializeField] private float autoDestroyTime;

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



    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
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
