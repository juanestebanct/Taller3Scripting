using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TextBullet : Bullet
{

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

        Debug.Log("¡HA IMPACTADO UN TEXTBULLET!");

    }
}
