using UnityEngine;

public abstract class AbstractBulletFactory<T> : MonoBehaviour
    where T : MonoBehaviour
{
    private static AbstractBulletFactory<T> instance;

    [SerializeField]
    private T baseObject;

    public static AbstractBulletFactory<T> Instance { get => instance; }

    private void Awake()
    {
        if (instance != null)
        {
            Destroy(this);
        }

        instance = this;
    }

    public virtual T CreateItem()
    {
        T cloneObject = Instantiate<T>(baseObject);
        return cloneObject;
    }
}