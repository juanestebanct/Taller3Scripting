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

   
    protected override Bullet RetrieveBulletFromTypePool()
    {
        return TextBFactory.Instance.CreateItem();
    }
}
