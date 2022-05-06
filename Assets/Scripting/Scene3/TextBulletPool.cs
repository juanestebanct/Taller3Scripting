public class TextBulletPool : FatherBulletPool
{
    private static TextBulletPool instance;

    public static TextBulletPool Instance { get => instance; private set => instance = value; }

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

    //buscar si hay que remplazar el override de RetrieveItemFromFactory()
    protected override Bullet RetrieveBulletFromTypePool()
    {
        return null; //FastBulletFactory.Instance.CreateItem();
    }
}
