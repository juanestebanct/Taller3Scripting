using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParticleBullet : Bullet
{
    public Transform effect;

    private ParticleSystem.EmissionModule particulas;

    // Start is called before the first frame update
    void Start()
    {
        particulas = effect.GetComponent<ParticleSystem>().emission;

        particulas.enabled = false;

        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    internal override void CollisionEffects()
    {
        //esta es la parte en la que hacemos el llamado a las particulas

        particulas.enabled = true;

        StartCoroutine(DetenerParticulas());


    }

    IEnumerator DetenerParticulas()
    {
        yield return new WaitForSeconds(0.5f);
        particulas.enabled = false;
    }
}
