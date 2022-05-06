using System.Collections.Generic;
using UnityEngine;

public abstract class FatherBulletPool : MonoBehaviour, I_Pool<Bullet>
{
    [SerializeField]
    private int poolSize = 10; 

    private List<Bullet> InstancePoolList = new List<Bullet>();

    private void Start()
    {
        FillPool();
    }

    //Llena el Pool con la cantidad de elemntos indicados en poolSize
    public void FillPool()
    {
        for (int i = 0; i < poolSize; i++)
        {
            CreateABullet();
        }
    }

    //Crea la bala como tal
    private void CreateABullet()
    {

    }

    //No vamos a usar Factory
    protected virtual Bullet RetrieveBulletFromTypePool()
    {
        //return BulletFactory.Instance.CreateItem(); //Revisar si necesitamos cambar el nombre
    }

    //Resetea la posición del clone en la escena
    private void ResetClonePosition(Bullet clone)
    {
        clone.transform.parent = transform;
        clone.gameObject.transform.position = transform.position;
        clone.gameObject.transform.rotation = transform.rotation;
    }

    public Bullet GetObject()
    {
        if (InstancePoolList.Count == 0)
        {
            CreateABullet();
        }

        Bullet availableInstance  = InstancePoolList[0];
        availableInstance .transform.parent = null;
        availableInstance.gameObject.SetActive(true);
        availableInstance.OnBulletGot(); //Revisar que se mantenga la nomenclatura
        InstancePoolList.Remove(availableInstance);

        return availableInstance;

    }

    //Recicla (desaactiva) la bala, para no tener que destruirla
    public void RecycleBullets(Bullet poolObject)
    {

        InstancePoolList.Add(poolObject);
        ResetClonePosition(poolObject);
        poolObject.gameObject.SetActive(false);

    }

}
