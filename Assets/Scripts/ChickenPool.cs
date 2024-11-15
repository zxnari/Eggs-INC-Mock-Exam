using UnityEngine;
using UnityEngine.Pool;

public class ChickenPool
{
    GameObject prefab;
    ObjectPool<GameObject> pool;
    int defaultSize;
    int maxSize;

    public ChickenPool(GameObject prefab, int defaultSize = 1, int maxSize = 10)
    {
        this.prefab = prefab;  
        this.defaultSize = defaultSize;  
        this.maxSize = maxSize;  

    }

    public GameObject GetObject(Vector3 position)
    {
        GameObject obj = pool.Get();
        obj.transform.position = position;
        return obj;
    }
}