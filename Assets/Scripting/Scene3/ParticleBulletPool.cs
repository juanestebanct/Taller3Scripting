public class ParticleBulletPool : FatherBulletPool
{
    private static ParticleBulletPool instance;

    public static ParticleBulletPool Instance { get => instance; private set => instance = value; }

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
    }

    //buscar con que remplazar el override de RetrieveItemFromFactory()
}
