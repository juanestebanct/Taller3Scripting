public class BulletPool : FatherBulletPool
{
    private static BulletPool instance;

    public static BulletPool Instance { get => instance; private set => instance = value; }

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
}