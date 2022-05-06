public class BlockBulletPool : FatherBulletPool
{
    private static BlockBulletPool instance;

    public static BlockBulletPool Instance { get => instance; private set => instance = value; }

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

    
    protected override Bullet RetrieveBulletFromTypePool()
    {
        return BlockBFactory.Instance.CreateItem();
    }
}
