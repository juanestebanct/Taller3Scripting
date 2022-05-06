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

    //buscar con que remplazar el override de RetrieveItemFromFactory()
    protected override Bullet RetrieveBulletFromTypePool()
    {
        return null; //FastBulletFactory.Instance.CreateItem();
    }
}
