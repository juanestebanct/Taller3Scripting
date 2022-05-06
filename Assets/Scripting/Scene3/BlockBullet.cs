using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockBullet : Bullet
{

    private Collider targetCollider;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    protected override void CollisionEffects()
    {
        //esta es la parte en la que desactivamos el disparo y el collider.

        //CON ESTO DESACTIVAMOS EL COLLIDER!!!
        // targetCollider.enabled = !targetCollider.enabled;

        


    }
}
