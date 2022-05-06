
public interface I_Pool<T>
{
    void FillPool();

    T GetObject();

    void RecycleBullets(T poolObject);
}
