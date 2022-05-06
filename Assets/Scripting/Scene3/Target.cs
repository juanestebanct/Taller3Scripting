using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Target : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter(Collision collision)
    {
        GameObject targetBullet = collision.gameObject;

        if(targetBullet.tag == "TextBullet")
        {
            targetBullet.GetComponent<TextBullet>().CollisionEffects();
        }

        else if(targetBullet.tag == "ParticleBullet")
        {
            targetBullet.GetComponent<ParticleBullet>().CollisionEffects();
        }

        else if (targetBullet.tag == "BlockBullet")
        {
            targetBullet.GetComponent<BlockBullet>().targetCollider = this.GetComponent<Collider>();
            targetBullet.GetComponent<BlockBullet>().CollisionEffects();
        }
    }
}
