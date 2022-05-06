using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockBullet : Bullet
{

    internal Collider targetCollider;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    internal override void CollisionEffects()
    {
        targetCollider.enabled = false;


    }

    IEnumerator DetenerParticulas()
    {
        yield return new WaitForSeconds(1f);
        targetCollider.enabled = true;
    }
}
