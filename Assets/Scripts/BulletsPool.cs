using System.Collections.Generic;
using UnityEngine;

public class BulletsPool
{
    private readonly Stack<GameObject> _pool = new Stack<GameObject>();    
    private readonly GameObject _prefab;

    public BulletsPool(GameObject prefab)
    {
        _prefab = prefab;
    }

    public GameObject Get(Vector3 position, Quaternion rotation)
    {
        GameObject result = (_pool.Count == 0) ? PrefabBuilder.Instantiate(_prefab, position, rotation) : _pool.Pop();

        return result;
    }

    public void Return(GameObject gameObject)
    {
        _pool.Push(gameObject);
    }

}
